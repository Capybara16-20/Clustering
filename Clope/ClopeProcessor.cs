using System;
using System.Collections.Generic;
using System.Linq;

namespace Clope
{
    /// <summary>
    /// Класс, реализующий алгоритм Clope
    /// </summary>
    public class ClopeProcessor
    {
        public string FileName { get; private set; }
        private string[][] transactions;
        private List<Cluster> clusters = new();
        int?[] transactionDistribution;

        /// <summary>
        /// Конструктор, вызывающий метод генерации набора транзакций
        /// </summary>
        /// <param name="count">Количество транзакций в наборе</param>
        /// <param name="minLength">Минимальная длина транзакции</param>
        /// <param name="maxLength">Максимальная длина транзакции</param>
        /// <param name="fileName">Имя файла</param>
        public ClopeProcessor(int count, int minLength, int maxLength, string fileName)
        {
            TransactionGenerator.GenerateTransactions(count, minLength, maxLength, fileName);
            try
            {
                transactions = FileProcessor.ReadTransactions(fileName);
                transactionDistribution = new int?[transactions.Length];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            FileName = fileName;
        }

        /// <summary>
        /// Конструктор для работы с имеющимся набором данных
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="isThereHeader">Есть ли заголовок</param>
        public ClopeProcessor(string fileName, bool isThereHeader)
        {
            try
            {
                transactions = FileProcessor.ReadTransactions(fileName, isThereHeader);
                transactionDistribution = new int?[transactions.Length];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            FileName = fileName;
        }

        /// <summary>
        /// Метод, реализующий алгоритм кластеризации
        /// </summary>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        public void ClusterData(double repulsion)
        {
            if (repulsion <= 1)
                throw new ArgumentException(nameof(repulsion));

            //Фаза 1 - инициализация
            #region
            clusters.Add(new Cluster(transactions[0]));
            transactionDistribution[0] = 0;
            for (int i = 1; i < transactions.Length; i++)
            {
                Cluster newCluster = new Cluster(transactions[i]);
                int clusterIndex = GetClusterIndexToAdd(transactions[i], newCluster, repulsion);

                if (clusterIndex < 0)
                {
                    clusters.Add(newCluster);
                    transactionDistribution[i] = clusters.Count - 1;
                }
                else
                {
                    clusters[clusterIndex].AddTransaction(transactions[i]);
                    transactionDistribution[i] = clusterIndex;
                }
            }
            #endregion

            //Фаза 2 - итерация
            int iterationsCount = 0;
            bool isMoved;
            do
            {
                isMoved = false;

                for (int i = 0; i < transactions.Length; i++)
                {
                    Cluster newCluster = new Cluster(transactions[i]);
                    int clusterIndex = GetClusterIndexToAdd(transactions[i], newCluster, repulsion);

                    int currentClusterIndex = transactionDistribution[i].Value;
                    if (currentClusterIndex != clusterIndex)
                    {
                        clusters[currentClusterIndex].DeleteTransaction(transactions[i]);
                        if (clusterIndex < 0)
                        {
                            clusters.Add(newCluster);
                            transactionDistribution[i] = clusters.Count - 1;
                        }
                        else
                        {
                            clusters[clusterIndex].AddTransaction(transactions[i]);
                            transactionDistribution[i] = clusterIndex;
                        }

                        isMoved = true;
                    }
                }

                iterationsCount++;
            }
            while (isMoved);

            /*ShowResult(repulsion);
            Console.WriteLine();*/
            Console.WriteLine("Количество кластеров: {0}", clusters.Count);
            Console.WriteLine("Количество итераций {0}", iterationsCount);
            Console.WriteLine("Profit: {0}", GetCurrentProfit(repulsion));
        }

        private int GetClusterIndexToAdd(string[] transaction, Cluster newCluster, double repulsion)
        {
            int clusterIndex = -1;
            double maxProfit = GetProfitAfterAddingCluster(newCluster, repulsion) - GetCurrentProfit(repulsion);
            for (int j = 0; j < clusters.Count; j++)
            {
                double newProfit = Cluster.GetProfitFromAdding(clusters[j], transaction, repulsion);
                if (newProfit > maxProfit)
                {
                    maxProfit = newProfit;
                    clusterIndex = j;
                }
            }

            return clusterIndex;
        }

        private double GetProfitAfterAddingCluster(Cluster cluster, double repulsion)
        {
            double numerator = cluster.GetProfit(repulsion);
            double denominator = cluster.TransactionsCount;
            foreach (Cluster existingCluster in clusters)
            {
                numerator += existingCluster.GetProfit(repulsion);
                denominator += existingCluster.TransactionsCount;
            }

            return numerator / denominator;
        }

        private double GetCurrentProfit(double repulsion)
        {
            double numerator = 0;
            double denominator = 0;
            foreach(Cluster cluster in clusters)
            {
                numerator += cluster.GetProfit(repulsion);
                denominator += cluster.TransactionsCount;
            }

            return numerator / denominator;
        }

        private void ShowResult(double repulsion)
        {
            for (int i = 0; i < clusters.Count; i++)
            {
                Console.WriteLine("Кластер {0}:", i + 1);
                /*Console.WriteLine("|t_i| = {0}", clusters[i].TransactionsCount);
                Console.WriteLine("S = {0}", clusters[i].Area);
                Console.WriteLine("W = {0}", clusters[i].Width);
                Console.WriteLine("Data:");
                for (int j = 0; j < clusters[i].Data.Count; j++)
                {
                    Console.Write("{0}:{1}\t", clusters[i].Data[j], clusters[i].Occurrences[j]);
                }
                Console.WriteLine();*/

                Console.WriteLine("Profit: {0}", clusters[i].GetProfit(repulsion));
                for (int j = 0; j < transactions.Length; j++)
                {
                    if (transactionDistribution[j] == i)
                    {
                        Console.Write("[{0}]\t", j + 1);
                        for (int k = 0; k < transactions[j].Length; k++)
                        {
                            Console.Write("{0}\t", transactions[j][k]);
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

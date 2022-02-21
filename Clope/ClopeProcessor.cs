using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clope
{
    /// <summary>
    /// Класс, реализующий алгоритм Clope
    /// </summary>
    public class ClopeProcessor
    {
        public string FileName { get; private set; }
        private readonly string[][] transactions;
        private List<Cluster> clusters = new();
        private readonly int[] transactionDistribution;

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
                transactionDistribution = new int[transactions.Length];
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
                transactionDistribution = new int[transactions.Length];
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
        /// <param name="fileName">Имя файла для записи результата</param>
        public void ClusterData(double repulsion, string fileName)
        {
            if (repulsion <= 1)
                throw new ArgumentException(nameof(repulsion));

            //Фаза 1 - инициализация
            #region
            clusters.Add(new Cluster(transactions[0]));
            transactionDistribution[0] = 0;
            for (int i = 1; i < transactions.Length; i++)
            {
                int clusterIndex = -1;
                Cluster newCluster = new Cluster(transactions[i]);
                double maxProfit = GetProfitFromAddingCluster(newCluster, repulsion) - GetCurrentProfit(repulsion);
                for (int j = 0; j < clusters.Count; j++)
                {
                    double newProfit = Cluster.GetProfitFromAdding(clusters[j], transactions[i], repulsion);
                    if (newProfit > maxProfit)
                    {
                        maxProfit = newProfit;
                        clusterIndex = j;
                    }
                }

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
            #region
            int iterationsCount = 0;
            bool isMoved;
            do
            {
                isMoved = false;

                for (int i = 0; i < transactions.Length; i++)
                {
                    int currentClusterIndex = transactionDistribution[i];
                    int clusterIndex = -1;
                    Cluster newCluster = new Cluster(transactions[i]);

                    double profitFromRemove = Cluster.GetProfitFromRemoving(clusters[currentClusterIndex], transactions[i], repulsion);
                    double maxProfit = GetProfitFromAddingCluster(newCluster, repulsion) + profitFromRemove - GetCurrentProfit(repulsion);
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        double profitFromAdd = Cluster.GetProfitFromAdding(clusters[j], transactions[i], repulsion);
                        double newProfit = profitFromAdd + profitFromRemove;
                        if (newProfit > maxProfit)
                        {
                            maxProfit = newProfit;
                            clusterIndex = j;
                        }
                    }
                    
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

            RemoveEmptyClusters();
            #endregion

            ShowResult(repulsion, iterationsCount, fileName);
        }

        /// <summary>
        /// Метод удаления пустых кластеров
        /// </summary>
        private void RemoveEmptyClusters()
        {
            List<int> indexes = clusters.Select((n, i) => new { Item = n, Index = i })
                .Where(n => n.Item.TransactionsCount == 0).Select(n => n.Index).ToList();

            for (int i = 0; i < transactions.Length; i++)
                for (int j = 0; j < indexes.Count; j++)
                    if (transactionDistribution[i] > indexes[j])
                        transactionDistribution[i]--;

            clusters = clusters.Where(n => n.TransactionsCount > 0).ToList();
        }

        /// <summary>
        /// Метод вычисления прироста функции стоимости при добавлении при добавлении нового кластера
        /// </summary>
        /// <param name="cluster">Добавляемый кластер</param>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
        private double GetProfitFromAddingCluster(Cluster cluster, double repulsion)
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

        /// <summary>
        /// Метод, вычисляющий текущую функцию стоимости
        /// </summary>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод вывода результата кластеризации на экран и записи в файл
        /// </summary>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <param name="iterationsCount">Количество выполненных итераций</param>
        /// <param name="fileName">Имя файла для записи</param>
        private void ShowResult(double repulsion, int iterationsCount, string fileName)
        {
            string result = GetResultString(repulsion, iterationsCount);
            Console.WriteLine(result);

            WriteResult(result, fileName);
        }

        /// <summary>
        /// Метод записи результата кластеризации в файл
        /// </summary>
        /// <param name="result">Строка результата</param>
        /// <param name="fileName">Имя файла</param>
        private static void WriteResult(string result, string fileName)
        {
            FileProcessor.WriteToFile(fileName, result);
        }

        /// <summary>
        /// Метод получения строки результата
        /// </summary>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <param name="iterationsCount">Количество выполненных итераций</param>
        /// <returns></returns>
        private string GetResultString(double repulsion, int iterationsCount)
        {
            const string transactionsCountPattern = "Количество транзакций: {0}";
            const string repulsionPattern = "Коэффициент отталкивания: {0}";
            const string clustersCountPattern = "Количество кластеров: {0}";
            const string iterationsCountPattern = "Количество итераций: {0}";
            const string profitPattern = "Profit: {0}";
            const string clusterPattern = "Кластер {0}:";
            const string objectPattern = "{0}\t";

            StringBuilder result = new();
            result.AppendLine(string.Format(transactionsCountPattern, transactions.Length));
            result.AppendLine(string.Format(repulsionPattern, repulsion));
            result.AppendLine(string.Format(clustersCountPattern, clusters.Count));
            result.AppendLine(string.Format(iterationsCountPattern, iterationsCount));
            result.AppendLine(string.Format(profitPattern, GetCurrentProfit(repulsion)));
            result.AppendLine();

            for (int i = 0; i < clusters.Count; i++)
            {
                result.AppendLine(string.Format(clusterPattern, i + 1));
                result.AppendLine(string.Format(profitPattern, clusters[i].GetProfit(repulsion)));

                IEnumerable<string[]> clusterTransactions = transactions
                    .Select((n, j) => new { Item = n, Index = j })
                    .Where(n => transactionDistribution[n.Index] == i).Select(n => n.Item);

                StringBuilder transactionString = new();
                foreach (string[] transaction in clusterTransactions)
                {
                    for (int j = 0; j < transaction.Length; j++)
                    {
                        transactionString.Append(string.Format(objectPattern, transaction[j]));
                    }
                    transactionString.AppendLine();
                }

                result.Append(transactionString);
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}

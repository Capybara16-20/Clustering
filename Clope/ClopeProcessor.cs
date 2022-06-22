using System;
using System.Collections.Generic;
using System.Linq;

namespace Clope
{
    public class ClopeProcessor
    {
        private readonly string[][] data;

        public ClopeProcessor(string[][] data)
        {
            if (data.Length < 2)
                throw new ArgumentException();

            this.data = data;
        }

        public Dictionary<string[], int> ClusterData(double repulsion, ref List<Cluster> clusters, out int iterationsCount, out double profit)
        {
            //Фаза 1 - Инициализация
            Dictionary<string[], int> distribution = new();
            clusters = new();
            clusters.Add(new Cluster());
            for (int i = 0; i < data.Length; i++)
            {
                double maxCost = 0;
                int bestCluster = -1;
                for (int j = 0; j < clusters.Count; j++)
                {
                    double addCost = GetAddCost(clusters[j], data[i], repulsion);
                    if (addCost > maxCost)
                    {
                        maxCost = addCost;
                        bestCluster = j;
                    }
                }

                if (clusters[bestCluster].TransactionsCount == 0)
                {
                    clusters.Add(new Cluster());
                }

                clusters[bestCluster].AddTransaction(data[i]);
                distribution.Add(data[i], bestCluster);
            }

            //Фаза 2 - Уточняющие итерации
            int iteration = 1;
            bool isMoved;
            do
            {
                isMoved = false;
                for (int i = 0; i < data.Length; i++)
                {
                    double maxCost = 0;
                    int bestCluster = -1;
                    int currentCluster = distribution[data[i]];
                    double removeCost = GetRemoveCost(clusters[currentCluster], data[i], repulsion);
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (j != currentCluster)
                        {
                            double cost = GetAddCost(clusters[j], data[i], repulsion) + removeCost;
                            if (cost > maxCost)
                            {
                                maxCost = cost;
                                bestCluster = j;
                            }
                        }
                    }

                    if (maxCost > 0)
                    {
                        if (clusters[bestCluster].TransactionsCount == 0)
                        {
                            clusters.Add(new Cluster());
                        }

                        clusters[currentCluster].DeleteTransaction(data[i]);
                        clusters[bestCluster].AddTransaction(data[i]);
                        distribution[data[i]] = bestCluster;

                        isMoved = true;
                    }
                }

                iteration++;
            }
            while (isMoved);
            iterationsCount = iteration;

            RemoveEmptyClusters(distribution, clusters);

            profit = GetProfit(repulsion, clusters);

            return distribution;
        }

        private static double GetAddCost(Cluster cluster, string[] transaction, double repulsion)
        {
            int size = cluster.Size;
            int n = cluster.TransactionsCount;
            int width = cluster.Width;

            int newSize = size + transaction.Length;
            int newN = n + 1;
            int newWidth = width;
            foreach (string obj in transaction)
                if (cluster.GetOccurrence(obj) == 0)
                    newWidth++;

            double newCost = (double)newSize * newN / Math.Pow(newWidth, repulsion);
            if (n == 0)
                return newCost;

            return newCost - (double)size * n / Math.Pow(width, repulsion);
        }

        private static double GetRemoveCost(Cluster cluster, string[] transaction, double repulsion)
        {
            double size = cluster.Size;
            int n = cluster.TransactionsCount;
            double width = cluster.Width;

            double newSize = size - transaction.Length;
            int newN = n - 1;
            double newWidth = width;
            foreach (string obj in transaction)
                if (cluster.GetOccurrence(obj) == 1)
                    newWidth--;

            return newSize * newN / Math.Pow(newWidth, repulsion) - size * n / Math.Pow(width, repulsion);
        }

        private static void RemoveEmptyClusters(Dictionary<string[], int> distribution, List<Cluster> clusters)
        {
            for (int i = clusters.Count - 1; i >= 0; i--)
            {
                if (clusters[i].TransactionsCount == 0)
                {
                    foreach (var transaction in distribution.Where(x => x.Value > i).ToDictionary(x => x.Key, x => x.Value))
                    {
                        distribution[transaction.Key]--;
                    }
                    clusters.RemoveAt(i);
                }
            }
        }

        private double GetProfit(double repulsion, List<Cluster> clusters)
        {
            double profit = 0;
            foreach(Cluster cluster in clusters)
                profit += cluster.Size * cluster.TransactionsCount / Math.Pow(cluster.Width, repulsion);

            return profit / data.Length;
        }
    }
}

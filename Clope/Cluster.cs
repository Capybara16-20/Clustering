using System;
using System.Collections.Generic;
using System.Linq;

namespace Clope
{
    /// <summary>
    /// Класс, представляющий кластер
    /// </summary>
    class Cluster
    {
        private const int startFrequency = 1;
        public int TransactionsCount { get; private set; }
        public List<string> Data { get; private set; }
        public List<int> Occurrences { get; private set; }
        public int Area { get; private set; }
        public int Width { get { return Data.Count; } }
        public double Height { get { return (double)Area / Width; } }

        public Cluster(string[] transaction)
        {
            Data = new();
            Occurrences = new();

            AddTransaction(transaction);
        }

        public void AddTransaction(string[] transaction)
        {
            TransactionsCount++;
            Area += transaction.Length;

            for (int i = 0; i < transaction.Length; i++)
            {
                if (GetOccurrenceFrequency(transaction[i]) == 0)
                {
                    Data.Add(transaction[i]);
                    Occurrences.Add(startFrequency);
                }
                else
                {
                    int objectIndex = Data.IndexOf(transaction[i]);
                    Occurrences[objectIndex]++;
                }
            }
        }

        public void DeleteTransaction(string[] transaction)
        {
            TransactionsCount--;
            Area -= transaction.Length;

            for (int i = 0; i < transaction.Length; i++)
            {
                int objectIndex = Data.IndexOf(transaction[i]);
                if (objectIndex < 0)
                    throw new ArgumentException(nameof(transaction));

                if (Occurrences[objectIndex] > startFrequency)
                {
                    Occurrences[objectIndex]--;
                }
                else
                {
                    Data.RemoveAt(objectIndex);
                    Occurrences.RemoveAt(objectIndex);
                }
            }
        }

        public int GetOccurrenceFrequency(string dataObject)
        {
            int objectIndex = Data.IndexOf(dataObject);
            if (objectIndex < 0)
                return 0;

            return Occurrences[objectIndex];
        }

        public double GetProfit(double repulsion)
        {
            return GetGradient(Area, Width, repulsion) * TransactionsCount;
        }
        
        public static double GetProfitFromAdding(Cluster cluster, string[] transaction, double repulsion)
        {
            int newArea = cluster.Area + transaction.Length;
            int newWidth = cluster.Width;
            for (int i = 0; i < transaction.Length; i++)
                if (cluster.GetOccurrenceFrequency(transaction[i]) == 0)
                    newWidth++;

            return GetGradient(newArea, newWidth, repulsion) * (cluster.TransactionsCount + 1)
                - GetGradient(cluster.Area, cluster.Width, repulsion) * cluster.TransactionsCount;
        }

        public static double GetProfitFromRemoving(Cluster cluster, string[] transaction, double repulsion)
        {
            int newArea = cluster.Area - transaction.Length;
            int newWidth = cluster.Width;
            for (int i = 0; i < transaction.Length; i++)
                if (cluster.GetOccurrenceFrequency(transaction[i]) == startFrequency)
                    newWidth--;

            return GetGradient(newArea, newWidth, repulsion) * (cluster.TransactionsCount - 1)
                - GetGradient(cluster.Area, cluster.Width, repulsion) * cluster.TransactionsCount;
        }

        private static double GetGradient(double area, double width, double repulsion)
        {
            return area / Math.Pow(width, repulsion);
        }
    }
}

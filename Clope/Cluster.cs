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

        /// <summary>
        /// Конструктор, добавляющий первую транзакцию в кластер
        /// </summary>
        /// <param name="transaction"></param>
        public Cluster(string[] transaction)
        {
            Data = new();
            Occurrences = new();

            AddTransaction(transaction);
        }

        /// <summary>
        /// Метод добавления транзакции в кластер
        /// </summary>
        /// <param name="transaction">Транзакция</param>
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
        
        /// <summary>
        /// Метод удаления транзакции из кластера
        /// </summary>
        /// <param name="transaction">Транзакция</param>
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

        /// <summary>
        /// Метод вычисления количества вхождений объекта в кластер
        /// </summary>
        /// <param name="dataObject">Объект транзакции</param>
        /// <returns></returns>
        public int GetOccurrenceFrequency(string dataObject)
        {
            int objectIndex = Data.IndexOf(dataObject);
            if (objectIndex < 0)
                return 0;

            return Occurrences[objectIndex];
        }

        /// <summary>
        /// Метод вычисления функции стоимости
        /// </summary>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
        public double GetProfit(double repulsion)
        {
            if (Width == 0)
                return 0;

            return GetGradient(Area, Width, repulsion) * TransactionsCount;
        }
        
        /// <summary>
        /// Метод вычисления прироста функции стоимости при добавлении транзакции
        /// </summary>
        /// <param name="cluster">Кластер</param>
        /// <param name="transaction">Транзакция</param>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод вычисления прироста функции стоимости при удалении транзакции
        /// </summary>
        /// <param name="cluster">Кластер</param>
        /// <param name="transaction">Транзакция</param>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод вычисления градиента
        /// </summary>
        /// <param name="area">Площадь кластера</param>
        /// <param name="width">Ширина кластера</param>
        /// <param name="repulsion">Коэффициент отталкивания</param>
        /// <returns></returns>
        private static double GetGradient(double area, double width, double repulsion)
        {
            if (width == 0)
                return 0;

            return area / Math.Pow(width, repulsion);
        }
    }
}

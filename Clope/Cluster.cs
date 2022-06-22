using System.Collections.Generic;

namespace Clope
{
    public class Cluster
    {
        private readonly int startOccurrence = 1;

        public Cluster()
        {
            TransactionsCount = 0;
            Size = 0;
            Data = new();
        }

        public int TransactionsCount { get; private set; }

        public Dictionary<string, int> Data { get; private set; }

        public int Size { get; private set; }

        public int Width { get { return Data.Count; } }

        public double Height { get { return Size / Width; } }

        public int GetOccurrence(string obj)
        {
            if (!Data.ContainsKey(obj))
                return 0;

            return Data[obj];
        }

        public void AddTransaction(string[] transaction)
        {
            TransactionsCount++;
            Size += transaction.Length;
            foreach (string obj in transaction)
            {
                if (Data.ContainsKey(obj))
                {
                    Data[obj]++;
                }
                else
                {
                    Data.Add(obj, startOccurrence);
                }
            }
        }

        public void DeleteTransaction(string[] transaction)
        {
            TransactionsCount--;
            Size -= transaction.Length;
            foreach (string obj in transaction)
            {
                if (GetOccurrence(obj) > startOccurrence)
                {
                    Data[obj]--;
                }
                else
                {
                    Data.Remove(obj);
                }
            }
        }
    }
}

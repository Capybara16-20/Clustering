using System;
using Clope;

namespace ClopeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*const string fileName = "transactions.txt";
            const string resultFileName = "result.txt";
            const int transactionsCount = 100;
            const int minTransactionLength = 4;
            const int maxTransactionLength = 7;
            const double repulsion = 3;

            try
            {
                ClopeProcessor processor = new ClopeProcessor(transactionsCount, minTransactionLength, maxTransactionLength, fileName);
                processor.ClusterData(repulsion, resultFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            const string fileName = "Чеки.txt";
            const string resultFileName = "result.txt";
            const bool isThereHeader = true;
            const double repulsion = 2;
            try
            {
                ClopeProcessor processor = new ClopeProcessor(fileName, isThereHeader);
                processor.ClusterData(repulsion, resultFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

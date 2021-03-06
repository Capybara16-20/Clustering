using System;
using System.Text;

namespace Clope
{
    /// <summary>
    /// Класс для генерации тестовых наборов данных
    /// </summary>
    static class TransactionGenerator
    {
        /// <summary>
        /// Метод генерации тестового набора данных
        /// </summary>
        /// <param name="count">Количество транзакций</param>
        /// <param name="minLength">Минимальная длина транзакции</param>
        /// <param name="maxLength">Максимальная длина транзакции</param>
        /// <param name="fileName">Имя создаваемого файла</param>
        public static void GenerateTransactions(int count, int minLength, int maxLength, string fileName)
        {
            const int startSymbolCode = 97;
            const int endSymbolCode = 122;
            const string symbolPattern = "{0}\t";

            Random rand = new();

            StringBuilder set = new();
            for (int i = 0; i < count; i++)
            {
                StringBuilder transaction = new();
                for (int j = 0; j < rand.Next(minLength, maxLength + 1); j++)
                {
                    transaction.Append(string.Format(symbolPattern, (char)rand.Next(startSymbolCode, endSymbolCode + 1)));
                }

                set.Append(transaction);
                set.AppendLine();
            }

            FileProcessor.WriteToFile(fileName, set.ToString());
        }
    }
}

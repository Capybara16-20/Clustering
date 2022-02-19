using System;

namespace Clope
{
    public class ClopeProcessor
    {
        public string FileName { get; private set; }

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
            FileName = fileName;
        }

        /// <summary>
        /// Конструктор для работы с имеющимся набором данных
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public ClopeProcessor(string fileName)
        {
            FileName = fileName;
        }


    }
}

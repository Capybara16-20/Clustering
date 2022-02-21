using System;
using System.IO;

namespace Clope
{
    /// <summary>
    /// Класс для работы с файлами
    /// </summary>
    static class FileProcessor
    {
        const string fileNotFoundErrorMessage = "Файл не найден.";
        const string invalidSetErrorMessage = "Некорректный набор данных.";

        public static string[][] ReadTransactions(string fileName, bool isThereHeader = false)
        {
            const char elementSeparator = '\t';
            int startLine = isThereHeader ? 1 : 0;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            string[] lines = ReadLines(filePath);
            if (lines.Length < 2)
                throw new ArgumentException(invalidSetErrorMessage);

            string[][] transactions = new string[lines.Length - startLine][];
            for (int i = startLine; i < lines.Length; i++)
                transactions[i - startLine] = lines[i].Split(elementSeparator);

            return transactions;
        }

        private static string[] ReadLines(string filePath)
        {
            string[] lines;
            if (File.Exists(filePath))
                lines = File.ReadAllLines(filePath);
            else
                throw new FileNotFoundException(fileNotFoundErrorMessage);

            return lines;
        }

        public static void WriteToFile(string fileName, string line)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            FileStream file = new(filePath, FileMode.Create);
            using (StreamWriter sw = new(file))
            {
                sw.WriteLine(line);
            }
        }
    }
}

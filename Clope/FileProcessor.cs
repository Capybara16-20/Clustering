using System;
using System.IO;

namespace Clope
{
    static class FileProcessor
    {
        const string fileNotFoundErrorMessage = "Файл не найден.";

        public static string[][] ReadTransactions(string fileName)
        {
            const char elementSeparator = '\t';

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            string[] lines = ReadLines(filePath);

            string[][] transactions = null;

            throw new NotImplementedException();

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

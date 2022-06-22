using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Clope
{
    public class FileProcessor
    {
        const string fileNotFoundErrorMessage = "Файл не найден.";
        const string invalidSetErrorMessage = "Некорректный набор данных.";

        public static Dictionary<string, string[]> ReadTransactions(string fileName, char separator, out int linesCount, bool isThereHeader = false)
        {
            int startLine = isThereHeader ? 1 : 0;

            Dictionary<string, string[]> data = new Dictionary<string, string[]>();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            string[] lines = ReadLines(filePath);
            if (lines.Length < 2)
                throw new ArgumentException(invalidSetErrorMessage);

            linesCount = lines.Length - startLine;
            for (int i = startLine; i < lines.Length; i++)
            {
                string[] lineParts = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (lineParts.Length != 2)
                    throw new ArgumentException(invalidSetErrorMessage);

                string name = lineParts[0];
                string element = lineParts[1];

                if (data.ContainsKey(name))
                {
                    List<string> objects = data[name].ToList();
                    objects.Add(element);
                    data[name] = objects.ToArray();
                }
                else
                {
                    data.Add(name, new string[] { element });
                }
            }

            return data;
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

        public static void WriteResult(string filePath, string result)
        {
            FileStream file = new FileStream(filePath, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(result);
            }
        }
    }
}

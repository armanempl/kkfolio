using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPls
{
    public class ProductLoader
    {
        public static List<string> LoadProductsFromFile(string filePath = "C:\\Users\\Konrad\\source\\repos\\Mocking\\MoqPls\\MoqPls\\Products.txt", TextWriter output = null)
        {
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count == 0)
                {
                    output?.WriteLine("Brak produktów do dodania w pliku. Uzupełnij plik Products.txt wartościami, aby je dodać");
                    return new List<string>();
                }

                return lines;
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is IOException)
            {
                output?.WriteLine($"Wystąpił błąd podczas wczytywania produktów z pliku: {ex.Message}");
                return new List<string>();
            }
        }

    }
}


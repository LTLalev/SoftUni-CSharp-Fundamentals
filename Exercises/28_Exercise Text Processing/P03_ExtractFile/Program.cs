using System;

namespace P03_ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string info = text.Substring(text.LastIndexOf('\\') + 1);
            int dotIndex = info.LastIndexOf('.');
            
            string fileName = info.Substring(0, dotIndex);
            string extension = info.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}

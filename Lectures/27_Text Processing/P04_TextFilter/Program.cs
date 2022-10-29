using System;
using System.Linq;

namespace P04_TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < banList.Length; i++)
            {
                string currWord = banList[i];
                text = text.Replace(currWord, new string('*', currWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}

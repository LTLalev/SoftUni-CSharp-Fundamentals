using System;
using System.Linq;

namespace P04_WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] filtredWords = words.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join('\n', filtredWords));
        }
    }
}

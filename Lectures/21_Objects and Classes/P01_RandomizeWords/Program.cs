using System;
using System.Linq;

namespace P01_RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            string[] strings = inputStr
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random rnd = new Random();
            var random = strings.OrderBy(x => rnd.Next()).ToList();
                
            foreach(var item in random)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Dictionary<int, int> countNumbers = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if(!countNumbers.ContainsKey(number))
                {
                    countNumbers.Add(number, 0);
                }

                countNumbers[number]++;
            }

            foreach (var number in countNumbers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}

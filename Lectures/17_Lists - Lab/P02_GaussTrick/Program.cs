using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if(numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.Remove(numbers[numbers.Count - 1]);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.Remove(numbers[numbers.Count - 1]);
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}

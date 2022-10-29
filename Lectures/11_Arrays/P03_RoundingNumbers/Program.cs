using System;
using System.Linq;

namespace P03_RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {(int)Math.Round(input[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

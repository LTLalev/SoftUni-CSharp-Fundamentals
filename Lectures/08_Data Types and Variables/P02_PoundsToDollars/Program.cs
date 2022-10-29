using System;

namespace P02_PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal rate = 1.31M;
            decimal usd = pound * rate;

            Console.WriteLine($"{usd:f3}");
        }
    }
}

using System;

namespace P03_ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}

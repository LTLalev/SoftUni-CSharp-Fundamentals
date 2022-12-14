using System;

namespace P09_SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i - sum);
                sum += i * i - sum;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

using System;

namespace P02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                int newN = n % 10;
                int result = n / 10;
                n = result;
                sum += newN;
            }

            Console.WriteLine(sum);
        }
    }
}

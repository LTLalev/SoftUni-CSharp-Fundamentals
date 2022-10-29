using System;

namespace PM03_FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numA = decimal.Parse(Console.ReadLine());
            decimal numB = decimal.Parse(Console.ReadLine());

            decimal diff = Math.Abs(numA - numB);

            const decimal eps = 0.000001M;

            if (diff < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

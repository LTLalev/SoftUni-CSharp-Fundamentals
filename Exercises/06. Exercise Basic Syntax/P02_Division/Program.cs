using System;

namespace P02_Division
{
    internal class Division
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxDivision = 0;

            if (num % 10 == 0)
            {
                maxDivision = 10;
            }
            else if (num % 7 == 0)
            {
                maxDivision = 7;
            }
            else if (num % 6 == 0)
            {
                maxDivision = 6;
            }
            else if (num % 3 == 0)
            {
                maxDivision = 3;
            }
            else if (num % 2 == 0)
            {
                maxDivision = 2;
            }

            if (maxDivision == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {maxDivision}");
            }
        }
    }
}

using System;

namespace P04_PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintFirtstTriangle(num);
            PrintSecondTriangle(num);
        }

        static void PrintFirtstTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSecondTriangle(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
    }
}

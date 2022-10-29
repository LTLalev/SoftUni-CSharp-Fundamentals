using System;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = n;
            int factorial = 0;

            while (input > 0)
            {
                int newN = input % 10;
                int num = input / 10;
                input = num;

                int result = 1;

                for (int i = 1; i <= newN; i++)
                {
                    result = result * i;
                }

                factorial += result;
            }

            if (factorial == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

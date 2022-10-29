using System;

namespace P12_RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int num = i;
                int sum = 0;

                while (num != 0)
                {
                    int currentDigit = num % 10;
                    num = num / 10;
                    sum += currentDigit;
                }

                bool isNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isNumber);
            }
        }
    }
}

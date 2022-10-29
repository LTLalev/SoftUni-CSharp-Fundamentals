using System;
using System.Linq;

namespace P06_EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEvenNum = 0;
            int sumOddNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    sumEvenNum += currentNum;
                }
                else
                {
                    sumOddNum += currentNum;
                }
            }

            int diffEvenOddSum = sumEvenNum - sumOddNum;

            Console.WriteLine(diffEvenOddSum);
        }
    }
}

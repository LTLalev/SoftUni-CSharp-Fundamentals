using System;
using System.Linq;

namespace P06_EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool HaveSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int c = numbers.Length - 1; c > i; c--)
                {
                    rightSum += numbers[c];
                }

                if (rightSum == leftSum)
                {
                    HaveSum = true;
                    Console.WriteLine(i);
                }
            }

            if (!HaveSum && numbers.Length > 1)
            {
                Console.WriteLine("no");
            }

            if (numbers.Length == 1 && HaveSum == false)
            {
                Console.WriteLine("0");
            }
        }
    }
}

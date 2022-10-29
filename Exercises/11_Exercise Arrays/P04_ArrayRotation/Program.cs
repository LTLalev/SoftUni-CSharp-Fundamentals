using System;
using System.Linq;

namespace P04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersOfRotation = int.Parse(Console.ReadLine()); ;
            int firstNumber = 0;

            for (int i = 0; i < numbersOfRotation; i++)
            {
                firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstNumber;
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}

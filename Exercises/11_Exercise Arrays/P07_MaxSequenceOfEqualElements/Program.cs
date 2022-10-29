using System;
using System.Linq;

namespace P07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequensLength = 0;
            int endIndex = 0;
            int maxLength = 0;
            int maxIndex = 0;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequensLength++;
                    endIndex = i + 1;

                    if (maxLength < sequensLength)
                    {
                        maxLength = sequensLength;
                        maxIndex = endIndex;
                    }
                }
                else
                {
                    sequensLength = 0;
                    endIndex = 0;
                }
            }

            for (int i = maxIndex; i >= maxIndex - maxLength; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

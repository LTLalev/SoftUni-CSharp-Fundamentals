using System;
using System.Linq;

namespace P02_PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumb = int.Parse(Console.ReadLine());
            int[] numbers = new int[countOfNumb];

            for (int i = 0; i < countOfNumb; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }

            Array.Reverse(numbers);

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}

using System;
using System.Linq;

namespace P01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] numbers = new int[3];
            int smallestNumber = GetSmallestNumbers(numbers);           

            PrintSmallestNum(smallestNumber);
        }       

        static int GetSmallestNumbers(int[] numbers)
        {
            for (int i = 0; i < 3; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                numbers[i] = numb;
            }
            
            int smallestNum = numbers.Min();

            return smallestNum;
        }
        static void PrintSmallestNum(int smallestNumber) => Console.WriteLine(smallestNumber);
        
    }
}

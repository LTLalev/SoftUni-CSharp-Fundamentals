using System;
using System.Linq;

namespace P05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int maxNum = numbers[i];
                bool IsMaxNum = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int currNum = numbers[j];
                    if(maxNum <= currNum)
                    {
                        IsMaxNum = false;
                        break;
                    }
                } 
                
                if(IsMaxNum)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}

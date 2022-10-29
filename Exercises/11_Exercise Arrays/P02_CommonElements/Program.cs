using System;
using System.Linq;

namespace P02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            string[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

           foreach (string first in firstArray)
            {
                foreach (string second in secondArray)
                {
                    if(first == second)
                    {
                        Console.Write($"{first} ");
                    }
                }
            }

           
        }
    }
}

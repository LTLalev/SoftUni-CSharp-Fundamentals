using System;
using System.Linq;

namespace P04_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Reverse(input);
            Console.WriteLine(string.Join(' ', input));
        }
    }
}

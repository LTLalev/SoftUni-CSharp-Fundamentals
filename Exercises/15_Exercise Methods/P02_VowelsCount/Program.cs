using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            
            CalculateAndPrintVowelsCount(input);
        }

        static void CalculateAndPrintVowelsCount(string input)
        {
            var vowels = new List<char>
            {
                'a', 'e', 'i', 'o', 'u'
            };

            int numbersOfVowels = input.Count(c => vowels.Contains(c));

            Console.WriteLine(numbersOfVowels);
        }
    }
}

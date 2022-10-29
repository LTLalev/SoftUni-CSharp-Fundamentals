using System;
using System.Linq;

namespace P09_PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool IsPalindrom = GetPalindrom(input);

                Console.WriteLine(IsPalindrom.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool GetPalindrom(string input)
        {
            bool IsPalindrom = false;

            char[] revInput = input.ToCharArray();
            Array.Reverse(revInput);
            string reverseInput = new string(revInput);

            return IsPalindrom = input == reverseInput ? true : false;
        }
    }
}

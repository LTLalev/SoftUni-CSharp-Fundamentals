using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool IsDiff = false;

            PrintIfLengthIsDiff(input, ref IsDiff);
            PrintIfPasswordNotContainsLettersAndDigits(input, ref IsDiff);
            PrintIfCountOfDigitISUnderTwo(input, ref IsDiff);

            if(!IsDiff)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void PrintIfLengthIsDiff(string input, ref bool IsDiff)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                IsDiff = true;
            }
        }

        static void PrintIfPasswordNotContainsLettersAndDigits(string input, ref bool IsDiff)
        {
            if (!Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                IsDiff = true;
            }
        }

        static void PrintIfCountOfDigitISUnderTwo(string input, ref bool IsDiff)
        {
            var count = input.Count(Char.IsDigit);

            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                IsDiff = true;
            }
        }
    }
}

using System;
using System.Linq;

namespace P06_MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string middleChar = GetTheMiddleChar(input);

            Console.WriteLine(middleChar);
        }

        static string GetTheMiddleChar(string input)
        {
            if(input.Length % 2 == 0)
            {
                return input.Substring(input.Length / 2 - 1, 2);
            }
            else
            {
                return input[input.Length / 2].ToString();
            }
        }
    }
}

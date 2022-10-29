using System;
using System.Text;

namespace PM04_ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder reverseInput = new StringBuilder();

            for (int reverseIndex = input.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                reverseInput.Append(input[reverseIndex]);
            }

            string output = reverseInput.ToString();

            Console.WriteLine(output);
        }
    }
}

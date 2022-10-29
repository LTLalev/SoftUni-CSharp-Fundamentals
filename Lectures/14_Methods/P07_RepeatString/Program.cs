using System;

namespace P07_RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numbersOfRepeats = int.Parse(Console.ReadLine());    

            string result = ConcatinateAndPrintString(input, numbersOfRepeats);

            Console.WriteLine(result);
        }

        private static string ConcatinateAndPrintString(string input, int numbersOfRepeats)
        {
            string result = string.Empty;
            for (int i = 0; i < numbersOfRepeats; i++)
            {
                result += input;
            }

            return result;
        }
    }
}

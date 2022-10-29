using System;

namespace PM05_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    result += " ";
                }
                else
                {
                    int inputLength = input.Length;

                    int digit = int.Parse(input);
                    int mainDigit = digit % 10;
                    int offset = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset += 1;
                    }

                    int letterIndex = (offset + inputLength - 1);
                    int index = letterIndex + 97;

                    char letters = (char)index;

                    result += letters;
                }
            }
            Console.WriteLine(result);
        }
    }
}

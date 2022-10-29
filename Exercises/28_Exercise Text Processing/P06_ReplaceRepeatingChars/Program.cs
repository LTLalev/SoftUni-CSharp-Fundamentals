using System;
using System.Text;

namespace P06_ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;
            result += text[0];
            int currIndex = 0;

            foreach (var ch in text)
            {
                if (result[currIndex] != ch)
                {
                    result += ch;
                    currIndex++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Text;

namespace P02_RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
           
            StringBuilder result = new StringBuilder();

            foreach (string s in input)
            {
                int repeats = s.Length;

                for (int i = 0; i < repeats; i++)
                {
                    result.Append(s);
                }
            }

            Console.WriteLine(result);
        }
    }
}

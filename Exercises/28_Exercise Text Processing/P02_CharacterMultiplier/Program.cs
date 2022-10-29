using System;
using System.Linq;

namespace P02_CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            string one = input[0];
            string two = input[1];

            int minLenght = Math.Min(one.Length, two.Length);

            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += one[i] * two[i];
            }

            if(one.Length < two.Length)
            {
                string subString = two.Substring(one.Length, two.Length - one.Length);

                foreach (char c in subString)
                {
                    sum += c;
                }
            }
            else
            {
                string subString = one.Substring(two.Length, one.Length - two.Length);
                foreach (char c in subString)
                {
                    sum += c;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

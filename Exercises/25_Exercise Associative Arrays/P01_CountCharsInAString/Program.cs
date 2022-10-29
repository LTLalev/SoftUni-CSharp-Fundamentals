using System;
using System.Collections.Generic;

namespace P01_CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string currLetter = input[i].ToString();                
               
                if(currLetter == " ")
                {
                    continue;
                }

                if (!dictionary.ContainsKey(currLetter))
                {
                    dictionary.Add(currLetter, 0);
                }
                
                dictionary[currLetter]++;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

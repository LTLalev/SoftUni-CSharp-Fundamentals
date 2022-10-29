using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();            

            Dictionary<string, int> elements = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                string currString = strings[i].ToLower(); 

                if (!elements.ContainsKey(currString))
                {
                    elements.Add(currString, 0);
                }

                elements[currString]++;
            }

            foreach (var kvp in elements)
            {
                if(kvp.Value % 2 != 0)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}

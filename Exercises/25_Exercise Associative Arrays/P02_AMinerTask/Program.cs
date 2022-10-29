using System;
using System.Collections.Generic;

namespace P02_AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, int> map = new Dictionary<string, int>();

            int count = 1;
            string currItem = string.Empty;

            while (input != "stop")
            {
                if(count % 2 != 0)
                {
                    currItem = input;

                    if(!map.ContainsKey(input))
                    {
                        map.Add(input, 0);
                    }                 
                }
                else
                {
                    map[currItem] += int.Parse(input);
                }

                count++;

                input = Console.ReadLine();
            }

            foreach (var kvp in map)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>()
            {
                { "shards", 0},
                { "motes", 0},
                { "fragments", 0}
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string obtainedItem = string.Empty;

            while (obtainedItem == string.Empty)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();                
                
                for (int i = 0; i < input.Length; i++)
                {
                    int quantity = int.Parse(input[i]);
                    string currMaterial = input[i + 1].ToLowerInvariant();
                    i++; 

                    if(keyMaterial.ContainsKey(currMaterial))
                    {
                        keyMaterial[currMaterial] += quantity;
                        obtainedItem = ObtainedItem(keyMaterial, currMaterial);

                        if(obtainedItem != string.Empty)
                        {
                            keyMaterial[currMaterial] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if(!junk.ContainsKey(currMaterial))
                        {
                            junk.Add(currMaterial, 0);
                        }

                        junk[currMaterial] += quantity;
                    }
                }
            }


            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var kvp in keyMaterial.Where(x => x.Value != 0))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk.Where(x => x.Value != 0))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static string ObtainedItem(Dictionary<string, int> keyMaterial, string currMaterial)
        {
            string obtainedItem = string.Empty;

            if (keyMaterial[currMaterial] >= 250)
            {
                if(currMaterial == "shards")
                {
                    obtainedItem = "Shadowmourne";
                }
                else if(currMaterial == "fragments")
                {
                    obtainedItem = "Valanyr";
                }
                else
                {
                    obtainedItem = "Dragonwrath";
                }
            }

            return obtainedItem;
        }
    }
}

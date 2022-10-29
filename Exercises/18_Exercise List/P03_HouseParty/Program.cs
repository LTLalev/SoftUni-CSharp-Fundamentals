using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int count = 0; count < numbersOfCommands; count++)
            {
                string[] inputs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputs[0];

                if(inputs.Length == 3)
                {
                    if(!names.Contains(name))
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {                    
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join('\n', names));
        }
    }
}

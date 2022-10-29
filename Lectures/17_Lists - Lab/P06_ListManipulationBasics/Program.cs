using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandsArgm = Console.ReadLine();

            while (commandsArgm != "end")
            {
                string[] commands = commandsArgm
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if(command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Remove(number);
                }
                else if(command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                }
                else
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, number);
                }
                commandsArgm = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }       
    }
}

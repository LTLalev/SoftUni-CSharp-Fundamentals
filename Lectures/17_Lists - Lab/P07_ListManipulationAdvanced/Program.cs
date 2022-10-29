using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_ListManipulationAdvanced
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
            bool IsChanged = false;

            while (commandsArgm != "end")
            {
                string[] commands = commandsArgm
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                    IsChanged = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Remove(number);
                    IsChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                    IsChanged = true;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, number);
                    IsChanged = true;
                }
                else if(command == "Contains")
                {
                    int number = int.Parse(commands[1]);
                    if(numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(command == "PrintEven")
                {
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 == 0)));
                }
                else if(command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 != 0)));
                }
                else if(command == "GetSum")
                {
                    Console.WriteLine(string.Join(' ', numbers.Sum()));
                }
                else
                {
                    string condition = commands[1];
                    int number = int.Parse(commands[2]);

                    if(condition == "<")
                    {
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x < number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x > number)));
                    }
                    else if(condition == "<=")
                    {
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x <= number)));
                    }
                    else if(condition == ">=")
                    {
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x >= number)));
                    }
                }

                commandsArgm = Console.ReadLine();
            }

            if(IsChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}

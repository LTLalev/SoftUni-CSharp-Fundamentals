using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputsArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputsArgm[0];

                if(command == "Add")
                {
                    int number = int.Parse(inputsArgm[1]);

                    numbers.Add(number);
                }
                else if(command == "Insert")
                {
                    int number = int.Parse(inputsArgm[1]);
                    int index = int.Parse(inputsArgm[2]);
                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if(command == "Remove")
                {
                    int index = int.Parse(inputsArgm[1]);

                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");               
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else
                {
                    string direction = inputsArgm[1];
                    int count = int.Parse(inputsArgm[2]);                  

                    if(direction == "left")
                    {
                        for (int repeat = 0; repeat < count; repeat++)
                        {
                            int firstElement = numbers.First();
                            numbers.RemoveAt(0);
                            numbers.Add(firstElement);
                        }
                    }
                    else
                    {
                        for (int repeat = 0; repeat < count; repeat++)
                        {
                            int lastElement = numbers.Last();
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastElement);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}

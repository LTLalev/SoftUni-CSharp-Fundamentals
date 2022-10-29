using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
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

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputArgm[0];

                if(command == "Delete")
                {
                    int element = int.Parse(inputArgm[1]);

                    numbers.RemoveAll(x => x == element);
                }
                else
                {
                    int element = int.Parse(inputArgm[1]);
                    int index = int.Parse(inputArgm[2]);

                    numbers.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}

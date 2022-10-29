using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfVagons = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputsArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if(inputsArgm.Length == 2)
                {
                    string command = inputsArgm[0];
                    int passengers = int.Parse(inputsArgm[1]);

                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(inputsArgm[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= maxCapacityOfVagons)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', train));
        }
    }
}

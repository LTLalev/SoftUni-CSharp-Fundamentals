using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputArgm[0];
                int index = int.Parse(inputArgm[1]);

                if(command == "Shoot")
                {
                    int power = int.Parse(inputArgm[2]);
                    
                    ShootTargets(targets, power, index);                    
                }
                else if(command == "Add")
                {
                    int value = int.Parse(inputArgm[2]);

                    AddTarget(targets, value, index);                    
                }
                else
                {
                    int radius = int.Parse(inputArgm[2]);

                    StrikeTargets(targets, radius, index);                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));
        }

        private static void StrikeTargets(List<int> targets, int radius, int index)
        {
            int strikeCount = radius * 2;

            if (index - radius >= 0 && index + radius < targets.Count )
            {
                for (int strike = 0; strike <= strikeCount; strike++)
                {
                    int currIndex = index - radius;
                    targets.RemoveAt(currIndex);
                }
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }

        private static void AddTarget(List<int> targets, int value, int index)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                Console.WriteLine("Invalid placement!");
            }
            else
            {
                targets.Insert(index, value);
            }
        }

        private static void ShootTargets(List<int> targets, int power, int index)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }          
        }
    }
}

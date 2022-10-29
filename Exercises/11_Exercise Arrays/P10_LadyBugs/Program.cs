using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (initialIndexes.Contains(i))//missing
                {
                    field[i] = 1;
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int ladybugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                //ladybug takes off
                field[ladybugIndex] = 0;

                //calculate where bug should be land
                int nextIndex = ladybugIndex;

                while (true) // missing
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length) // bugs flight away
                    {
                        break;
                    }

                    if (field[nextIndex] == 0)// next index is empty and bugs land
                    {
                        break;
                    }

                }

                //ladybug land
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}

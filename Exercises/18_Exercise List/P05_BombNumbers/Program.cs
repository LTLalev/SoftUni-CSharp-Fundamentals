using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int[] bombNumAndPower = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNum = bombNumAndPower[0];
            int bombPower = bombNumAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombIndex = numbers.IndexOf(bombNum);

                if (numbers.Contains(bombNum))
                {

                    //Delete left
                    int startIndex = bombIndex - bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    for (int count = 0; count < bombPower; count++)
                    {
                        numbers.RemoveAt(startIndex);
                    }

                    //Delete right

                    for (int count = 0; count < bombPower + 1; count++)
                    {
                        if (startIndex > numbers.Count - 1)
                        {
                            break;
                        }

                        numbers.RemoveAt(startIndex);
                    }

                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}

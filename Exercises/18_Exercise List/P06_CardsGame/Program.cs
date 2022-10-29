using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCard = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCard = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while(firstPlayerCard.Count > 0 && secondPlayerCard.Count > 0)
            {
                if (firstPlayerCard[0] > secondPlayerCard[0])
                {
                    firstPlayerCard.Add(secondPlayerCard[0]);
                    firstPlayerCard.Add(firstPlayerCard[0]);
                    firstPlayerCard.RemoveAt(0);
                    secondPlayerCard.RemoveAt(0);
                }
                else if (firstPlayerCard[0] < secondPlayerCard[0])
                {
                    secondPlayerCard.Add(firstPlayerCard[0]);
                    secondPlayerCard.Add(secondPlayerCard[0]);
                    firstPlayerCard.RemoveAt(0);
                    secondPlayerCard.RemoveAt(0);
                }
                else
                {
                    firstPlayerCard.RemoveAt(0);
                    secondPlayerCard.RemoveAt(0);
                }
            }

            if(firstPlayerCard.Count > 0)
            {
                int sum = firstPlayerCard.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondPlayerCard.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}

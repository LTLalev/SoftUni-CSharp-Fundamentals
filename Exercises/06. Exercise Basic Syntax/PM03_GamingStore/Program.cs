using System;

namespace PM03_GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double spentMoney = 0;
            double remainingMoney = currentBalance;

            while (currentBalance > 0)
            {
                string game = Console.ReadLine();

                double price = 0;

                switch (game)
                {
                    case "Game Time":
                        double remain = remainingMoney - spentMoney;
                        Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${remain:f2}");
                        return;
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    spentMoney += price;
                    currentBalance -= price;
                    Console.WriteLine($"Bought {game}");
                    continue;

                }
            }

            Console.WriteLine("Out of money!");
        }
    }
}

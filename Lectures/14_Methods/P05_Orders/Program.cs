using System;

namespace P05_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = CalculatePrice(product, quantity);
            PrintPrice(price);
        }

        private static void PrintPrice(double price)
        {
            Console.WriteLine($"{price:f2}");
        }

        static double CalculatePrice(string product, int quantity)
        {
            var price = 0.0;
            var coffeePrice = 1.50;
            var waterPrice = 1.00;
            var cokePrice = 1.40;
            var snackPrice = 2.00;

            if(product == "coffee")
            {
                price = quantity * coffeePrice;
            }
            else if(product == "water")
            {
                price = quantity * waterPrice;
            }
            else if(product == "coke")
            {
                price = quantity * cokePrice;
            }
            else
            {
                price = quantity * snackPrice;
            }

            return price;
        }
    }
}

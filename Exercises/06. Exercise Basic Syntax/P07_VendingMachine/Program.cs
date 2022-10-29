using System;

namespace P07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "start")
                {
                    while (true)
                    {
                        input = Console.ReadLine().ToLower();

                        double price = 0;

                        if (input == "end")
                        {
                            Console.WriteLine($"Change: {sum:f2}");
                            return;
                        }
                        else if (input == "nuts")
                        {
                            price += 2.0;
                        }
                        else if (input == "water")
                        {
                            price += 0.7;
                        }
                        else if (input == "crisps")
                        {
                            price += 1.5;
                        }
                        else if (input == "soda")
                        {
                            price += 0.8;
                        }
                        else if (input == "coke")
                        {
                            price += 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Invalid product");
                            continue;
                        }

                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {input}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        continue;
                    }
                }

                double coins = double.Parse(input);

                if (coins != 0.10 && coins != 0.20 && coins != 0.50 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }

                sum += coins;
            }
        }
    }
}

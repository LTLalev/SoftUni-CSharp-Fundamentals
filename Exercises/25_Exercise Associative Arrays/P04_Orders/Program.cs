using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputArgm[0];
                double price = double.Parse(inputArgm[1]);
                int quantity = int.Parse(inputArgm[2]);                

                if(!products.ContainsKey(name))
                {
                    products.Add(name, new double[2]);
                    products[name][0] = 0;
                    products[name][1] = 0;
                }
    
                products[name][0] = price;  
                products[name][1] += quantity;

                input = Console.ReadLine();
            }

            foreach (var kvp in products)
            {
                string product = kvp.Key;
                double price = kvp.Value[0];
                double quantity = kvp.Value[1];
                double totalPrice = price * quantity;

                Console.WriteLine($"{product} -> {totalPrice:f2}");                
            }
        }
    }
}

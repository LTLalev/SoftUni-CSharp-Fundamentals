using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();
            int number = 1; 
            foreach (var item in products)
            {
                Console.WriteLine($"{number}.{item}");
                number++;
            }
        }
    }
}

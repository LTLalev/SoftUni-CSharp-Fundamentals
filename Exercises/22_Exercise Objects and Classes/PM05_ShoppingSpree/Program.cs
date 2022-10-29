using System;
using System.Collections.Generic;
using System.Linq;

namespace PM05_ShoppingSpree
{
    class Person
    {
        public Person(string personName, double personMoney, string product)
        {
            Name = personName;
            Money = personMoney;
            BagOfProducts = new List<string>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> BagOfProducts { get; set; }
    }

    class Product
    {
        public Product(string productName, double productCost)
        {
            Name = productName;
            Cost = productCost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Person> persons = new List<Person>();

            string product = string.Empty;

            for (int i = 1; i <= 2; i++)
            {
                string input = Console.ReadLine();

                char[] delimiters = { '=', ';' };
                List<string> inputs = input
                    .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (i == 1)
                {
                    AddPerson(inputs, persons, product);
                }
                else
                {
                    AddProducts(inputs, products, product);
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commands = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = commands[0];
                product = commands[1];

                AddProductAndReduceMoney(persons, products, name, product);

                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");

                }
            }
        }

        static void AddProductAndReduceMoney(List<Person> persons, List<Product> products, string name, string product)
        {
            double personMoney = persons.Find(n => n.Name == name).Money;
            double productCost = products.Find(n => n.Name == product).Cost;

            if (personMoney >= productCost)
            {
                persons.Find(n => n.Name == name).BagOfProducts.Add(product);
                persons.Find(n => n.Name == name).Money -= products.Find(n => n.Name == product).Cost;
                Console.WriteLine($"{name} bought {product}");
            }
            else
            {
                Console.WriteLine($"{name} can't afford {product}");
            }
        }

        static void AddPerson(List<string> inputs, List<Person> persons, string product)
        {
            while (inputs.Count != 0)
            {
                string personName = inputs[0];
                double personMoney = double.Parse(inputs[1]);

                Person newPerson = new Person(personName, personMoney, product);
                persons.Add(newPerson);

                inputs.RemoveRange(0, 2);
            }
        }

        static void AddProducts(List<string> inputs, List<Product> products, string product)
        {
            while (inputs.Count != 0)
            {
                string productName = inputs[0];
                double productCost = double.Parse(inputs[1]);

                Product newProduct = new Product(productName, productCost);
                products.Add(newProduct);

                inputs.RemoveRange(0, 2);
            }
        }
    }
}

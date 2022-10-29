using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StoreBoxes
{
    class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
       public string Name { get; set; }
       public double Price { get; set; }
    }

    class Box
    {
        public Box(int serialNumber, Item item, int itemQuality, double price)
        {
            this.SerianNumber = serialNumber;
            this.Item = item;
            this.ItemQuality = itemQuality;
            this.Price = price;
        }
       
        public int SerianNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuality { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int serialNumber = int.Parse(inputArgm[0]);
                string itemName = inputArgm[1];
                int itemQuality = int.Parse(inputArgm[2]);
                double itemPrice = double.Parse(inputArgm[3]);

                double priceOfOneBox = itemQuality * itemPrice;

                Item item = new Item(itemName, itemPrice);                

                Box box = new Box(serialNumber, item, itemQuality, priceOfOneBox);
                boxes.Add(box);
                input = Console.ReadLine();
            }
           
            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (var box in orderedBoxes)
            {
                int boxSerialNumber = box.SerianNumber;
                Console.WriteLine($"{boxSerialNumber}");
                
                string boxItemName = box.Item.Name;
                double boxItemPrice = box.Item.Price;
                int boxItemQuantity = box.ItemQuality;

                Console.WriteLine($"-- {boxItemName} - ${boxItemPrice:f2}: {boxItemQuantity}");

                double boxPrice = box.Price;

                Console.WriteLine($"-- ${boxPrice:f2}");
            }
        }
    }
}

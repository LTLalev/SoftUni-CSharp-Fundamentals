using System;

namespace P03_Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();

            double price = 0;

            if (day == "friday")
            {
                if (typeOfGroup == "students")
                {
                    price = 8.45;
                }
                else if (typeOfGroup == "business")
                {
                    price = 10.90;
                }
                else
                {
                    price = 15;
                }
            }
            else if (day == "saturday")
            {
                if (typeOfGroup == "students")
                {
                    price = 9.80;
                }
                else if (typeOfGroup == "business")
                {
                    price = 15.60;
                }
                else
                {
                    price = 20;
                }
            }
            else
            {
                if (typeOfGroup == "students")
                {
                    price = 10.46;
                }
                else if (typeOfGroup == "business")
                {
                    price = 16;
                }
                else
                {
                    price = 22.50;
                }
            }

            double totalPrice = numberOfPeople * price;
            if (typeOfGroup == "students" && numberOfPeople >= 30)
            {
                double percentDiscount = 0.85;
                totalPrice *= percentDiscount;

            }
            else if (typeOfGroup == "business" && numberOfPeople >= 100)
            {
                double discount = 10 * price;
                totalPrice -= discount;
            }
            else if (typeOfGroup == "regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                double percentDiscount = 0.95;
                totalPrice *= percentDiscount;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

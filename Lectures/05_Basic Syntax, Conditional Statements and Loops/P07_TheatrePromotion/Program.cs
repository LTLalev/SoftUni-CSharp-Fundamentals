using System;

namespace P07_TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            bool isAge0To18 = age >= 0 && age <= 18;
            bool isAge18To64 = age > 18 && age <= 64;
            bool isAge64To112 = age > 64 && age <= 122;
            int price = 0;

            if (isAge0To18)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
            }
            else if (isAge18To64)
            {
                if (typeOfDay == "weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
            }
            else if (isAge64To112)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
            }

            if (isAge0To18 || isAge18To64 || isAge64To112)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

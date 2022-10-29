using System;

namespace P09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double percentExtraSabers = 1.10;
            double numberOfLightsabers = Math.Ceiling(countStudents * percentExtraSabers);

            double totalPriceSabers = numberOfLightsabers * priceOfLightsabers;
            double totalPriceRobes = countStudents * priceOfRobes;
            double totalPriceBelts = countStudents * priceOfBelts;

            for (int i = 1; i <= countStudents; i++)
            {
                if (i % 6 == 0)
                {
                    totalPriceBelts -= priceOfBelts;
                }
            }

            double totalPriceToPay = totalPriceSabers + totalPriceRobes + totalPriceBelts;

            if (totalPriceToPay <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceToPay:f2}lv.");
            }
            else
            {
                double diff = totalPriceToPay - amountOfMoney;
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}

using System;

namespace P10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalPriceKeyboard = (lostGameCount / 6) * keyboardPrice;
            double totalPriceDisplay = (lostGameCount / 12) * displayPrice;
            double totalPriceHeadset = (lostGameCount / 2) * headsetPrice;
            double totalMousePrice = (lostGameCount / 3) * mousePrice;

            double expenses = totalPriceKeyboard + totalPriceDisplay + totalPriceHeadset + totalMousePrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

using System;

namespace P08_BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double maxValue = double.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                double value = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;

                if (value > maxValue)
                {
                    maxValue = value;
                    biggestKeg = modelOfKeg;
                }
            }

            Console.WriteLine($"{biggestKeg}");
        }
    }
}

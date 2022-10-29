using System;

namespace P09_SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int currentlyYield = startingYield;

            const int dayConsumation = 26;
            const int yieldDrops = 10;
            const int minYield = 100;

            int days = 0;
            int leftSpices = 0;
            int total = 0;

            if (startingYield >= 100)
            {
                while (true)
                {
                    days++;
                    leftSpices = currentlyYield - dayConsumation;
                    currentlyYield -= yieldDrops;
                    total += leftSpices;

                    if (currentlyYield < minYield)
                    {
                        break;
                    }

                    startingYield -= yieldDrops;
                }

                total -= dayConsumation;
            }

            Console.WriteLine($"{days}");
            Console.WriteLine($"{total}");
        }
    }
}

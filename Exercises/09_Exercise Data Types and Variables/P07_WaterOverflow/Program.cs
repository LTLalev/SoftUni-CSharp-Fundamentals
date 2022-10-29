using System;

namespace P07_WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfInputs = byte.Parse(Console.ReadLine());

            const byte capacityTank = 255;
            ushort volume = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                ushort quantityOfWater = ushort.Parse(Console.ReadLine());

                volume += quantityOfWater;

                if (volume > capacityTank)
                {
                    volume -= quantityOfWater;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }

            Console.WriteLine($"{volume}");
        }
    }
}

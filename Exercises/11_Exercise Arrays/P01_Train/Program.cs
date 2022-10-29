using System;
using System.Linq;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfVagons = int.Parse(Console.ReadLine());

            int[] trainPassengers = new int[numbersOfVagons];

            for (int i = 0; i < numbersOfVagons; i++)
            {
                int numbersOfPassengers = int.Parse(Console.ReadLine());

                trainPassengers[i] = numbersOfPassengers;
            }

            int totalCountPassengers = trainPassengers.Sum();
            Console.WriteLine(String.Join(" ", trainPassengers));
            Console.WriteLine(totalCountPassengers);
        }
    }
}

using System;

namespace P10_PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());//M
            int exhaustionFactor = int.Parse(Console.ReadLine());//Y

            int currentlyPokePower = pokePower; //N
            long countTargets = 0;
            double fiftyPercentOfPower = pokePower * 0.5;

            while (currentlyPokePower >= distanceBetweenTargets)
            {
                currentlyPokePower -= distanceBetweenTargets;
                countTargets++;

                if (currentlyPokePower == fiftyPercentOfPower && exhaustionFactor != 0)
                {
                    currentlyPokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine($"{currentlyPokePower}");
            Console.WriteLine($"{countTargets}");
        }
    }
}

using System;
using System.Numerics;

namespace P11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int highestBall = 0;

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int BestSnowballQuality = 0;
            BigInteger bestSnowballValue = BigInteger.Zero;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballDivid = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(snowballDivid, snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    BestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({BestSnowballQuality})");

        }
    }
}

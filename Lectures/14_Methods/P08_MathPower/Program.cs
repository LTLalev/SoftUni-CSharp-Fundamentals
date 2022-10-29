using System;

namespace P08_MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theBase = double.Parse(Console.ReadLine());
            double thePower = double.Parse(Console.ReadLine());

            var result = CalculatePower(theBase, thePower);
            
            Console.WriteLine(result);
        }

        private static double CalculatePower(double theBase, double thePower)
        {
            double result = Math.Pow(theBase, thePower);
          
            return result;
        }
    }
}

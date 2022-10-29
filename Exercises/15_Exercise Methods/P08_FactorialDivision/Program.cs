using System;

namespace P08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            var firstNumFac = CalculateFactorial(num1);
            var secondNumFac = CalculateFactorial(num2);

            var factDivision = CalculateDivision(firstNumFac, secondNumFac);         
            PrintResult(factDivision);
        }

        static double CalculateFactorial(double num)
        {
            double factorial = 1;

            for (int i = 1; i < num; i++)
            {
                factorial *= (i + 1);
            }

            return factorial;
        }

        static double CalculateDivision(double firstNumFact, double secondNumFact) => firstNumFact / secondNumFact;

        static void PrintResult(double factDivision) => Console.WriteLine($"{factDivision:f2}");
    }
}

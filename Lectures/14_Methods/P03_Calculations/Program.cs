using System;

namespace P03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string command = Console.ReadLine();
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double result = 0;

            if(command == "add")
            {
                result = CalculateAdd(num1, num2);
            }
            else if (command == "multiply")
            {
                result = CalculateMultiply(num1, num2);
            }
            else if (command == "subtract")
            {
                result = CalculateSubstract(num1, num2);
            }
            else
            {
                result = CalculateDivide(num1, num2);
            }

            PrintResult(result);
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine(result);
        }

        private static double CalculateDivide(double num1, double num2)
        {
            double result = 0;
            result = num1 / num2;

            return result;
        }

        private static double CalculateSubstract(double num1, double num2)
        {
            double result = 0;
            result = num1 - num2;

            return result;
        }

        static double CalculateAdd(double num1, double num2)
        {
            double result = 0;
            result = num1 + num2;

            return result;
        }

        static double CalculateMultiply(double num1, double num2)
        {
            double result = 0;
            result = num1 * num2;

            return result;
        }
    }
}

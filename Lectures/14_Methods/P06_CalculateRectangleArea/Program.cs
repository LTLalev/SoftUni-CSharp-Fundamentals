using System;

namespace P06_CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            var area = CalculateTriangleArea(sideA, sideB);

            PrintArea(area);
        }

        private static void PrintArea(double area)
        {
            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double sideA, double SideB)
        {
            double area = sideA * SideB;

            return area;
        }
    }
}

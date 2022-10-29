using System;

namespace PM02_CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            if (CalculateClosestPoints(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static bool CalculateClosestPoints(double x1, double y1, double x2, double y2)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            x2 = Math.Abs(x2);
            y2 = Math.Abs(y2);

            if ((x1 <= x2 && y1 <= y2) || (x1 >= x2 && y1 < y2) || (x1 <= x2 && y1 < y2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

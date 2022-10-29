using System;

namespace PM03_LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var longerLineLength = double.MinValue;
            var lineLength = double.MinValue;
            var closestX1 = 0.0;
            var closestY1 = 0.0;
            var closestX2 = 0.0;
            var closestY2 = 0.0;

            for (int i = 0; i < 2; i++)
            {
                var x1 = double.Parse(Console.ReadLine());
                var y1 = double.Parse(Console.ReadLine());
                var x2 = double.Parse(Console.ReadLine());
                var y2 = double.Parse(Console.ReadLine());

                lineLength = GetLongestLine(x1, y1, x2, y2);

                if (lineLength > longerLineLength)
                {
                    longerLineLength = lineLength;
                    closestX1 = x1;
                    closestY1 = y1;
                    closestX2 = x2;
                    closestY2 = y2;
                }
            }

            double firstDistance = ClosestPoint(closestX1, closestY1);
            double secondDistance = ClosestPoint(closestX2, closestY2);


            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({closestX1}, {closestY1})({closestX2}, {closestY2})");
            }
            else
            {
                Console.WriteLine($"({closestX2}, {closestY2})({closestX1}, {closestY1})");
            }
        }

        static double GetLongestLine(double x1, double y1, double x2, double y2)
        {
            double lineLength = 0.0;
            lineLength = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            return lineLength;
        }

        static double ClosestPoint(double closestX1, double closestY1)
        {
            double closerPoints = Math.Sqrt(Math.Pow((0 - closestX1), 2) + Math.Pow((0 - closestY1), 2));

            return closerPoints;
        }
    }
}

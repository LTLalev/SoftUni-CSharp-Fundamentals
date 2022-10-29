using System;
using System.Linq;

namespace PM05_MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double[] array = new double[]
            {
                num1,
                num2,
                num3
            };

           PrintAndFindTypeOfNumbers(array);
        }

        static void PrintAndFindTypeOfNumbers(double[] array)
        {
            var positiveCount = array.Where(x => x > 0).Count();
            var zeroCount = array.Where(x => x == 0).Count();
            var negativeCount = array.Where(x => x < 0).Count();

            if (zeroCount > 0)
            {
                Console.WriteLine("zero");
            }
            else if (positiveCount == 3)
            {
                Console.WriteLine("positive");
            }
            else if (negativeCount == 3)
            {
                Console.WriteLine("negative");
            }
            else if (positiveCount == 2)
            {
                Console.WriteLine("negative");
            }
            else if (positiveCount == 1)
            {
                Console.WriteLine("positive");
            }
        }
    }
}

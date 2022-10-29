using System;

namespace PM01_DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (Double.TryParse(input, out double numberFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (Char.TryParse(input, out char value))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (Boolean.TryParse(input, out bool flag))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}

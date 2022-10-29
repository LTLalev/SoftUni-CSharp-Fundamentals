using System;

namespace P11_RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = 0.0;
            volume = (length * width * height) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}

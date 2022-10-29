using System;

namespace P07_ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            Console.WriteLine($"{first}{third}{second}"); ;
        }
    }
}

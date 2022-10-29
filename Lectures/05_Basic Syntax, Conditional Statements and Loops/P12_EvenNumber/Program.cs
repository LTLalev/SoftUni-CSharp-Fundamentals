﻿using System;

namespace P12_EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while ((num = int.Parse(Console.ReadLine())) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }

            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}

﻿using System;

namespace P04_SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char latinAlphabet = char.Parse(Console.ReadLine());

                sum += latinAlphabet;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

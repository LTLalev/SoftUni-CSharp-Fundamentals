using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> newList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();            

            for (int i = 0; i < newList.Count - 1; i++)
            {
                if (newList[i] == newList[i + 1])
                {
                    newList[i] += newList[i + 1];
                    newList.RemoveAt(i + 1);                    
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', newList));
        }
    }
}

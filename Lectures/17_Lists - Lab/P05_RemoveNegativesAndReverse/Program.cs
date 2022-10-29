using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //for (int i = firstList.Count - 1; i >= 0; i--)
            //{
            //    if (firstList[i] < 0)
            //    {
            //        firstList.RemoveAt(i);
            //    }
            //}

            firstList.RemoveAll(x => x < 0);           

            firstList.Reverse();

            if(firstList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', firstList));
            }
        }
    }
}

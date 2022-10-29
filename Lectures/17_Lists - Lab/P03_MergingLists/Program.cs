using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if(firstList.Count > secondList.Count)
            {
                int currentIndex = 0;
                for (int i = 1; i < secondList.Count * 2; i+=2)
                {
                    firstList.Insert(i, secondList[currentIndex]);
                    currentIndex++;
                }
                
                Console.WriteLine(string.Join(' ', firstList));
            }
            else
            {
                int currentIndex = 0;
                for (int i = 0; i < firstList.Count * 2; i += 2)
                {
                    secondList.Insert(i, firstList[currentIndex]);
                    currentIndex++;
                }

                Console.WriteLine(string.Join(' ', secondList));
            }
        }
    }
}

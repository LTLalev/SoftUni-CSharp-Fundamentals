using System;
using System.Linq;

namespace P09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());

            string input = string.Empty;

            int[] sequences = new int[lengthOfSequences];
            int[] maxSequences = new int[lengthOfSequences];

            int countMaxEqual = -1;
            int currentIndex = 0;
            int startIndex = -1;
            int bestSequenceIndex = 0;
            int sum = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sequences = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currentIndex++;

                int currentMaxEq = 0;
                int countEqual = 0;
                int currEndIndex = 0;
                bool IsCurrDnaIsBetter = false;

                for (int i = 0; i < sequences.Length; i++)
                {
                    if (sequences[i] != 1)
                    {
                        countEqual = 0;
                        continue;
                    }
                    
                    countEqual++;                       

                    if (currentMaxEq < countEqual)
                    {
                        currentMaxEq = countEqual;
                        currEndIndex = i;
                    }                    
                }

                int currStartIndex = currEndIndex - currentMaxEq + 1;
                int currentSum = sequences.Sum();            

                if (currentMaxEq > countMaxEqual)
                {                   
                    IsCurrDnaIsBetter = true;
                }
                else if (currentMaxEq == countMaxEqual)
                {
                    if (startIndex > currStartIndex)
                    {
                        IsCurrDnaIsBetter = true;                        
                    }
                    else if (startIndex == currStartIndex)
                    {
                        if (currentSum > sum)
                        {
                            IsCurrDnaIsBetter = true;                           
                        }
                    }
                }

                if(IsCurrDnaIsBetter)
                {
                    maxSequences = sequences;
                    countMaxEqual = currentMaxEq;
                    startIndex = currStartIndex;
                    sum = currentSum;
                    bestSequenceIndex = currentIndex;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {sum}.");
            Console.WriteLine(String.Join(' ', maxSequences), "DNA sequence, joined by space");
        }
    }
}

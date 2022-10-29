using System;
using System.Linq;

namespace P08_LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();          

            double totalSum = 0;

            foreach (string inputItem in input)
            {
                string currString = inputItem;
                
                char letterBeforeNumb = currString[0];
                int positionLetterBeforeNumb = 0;

                char letterAfterNumb = currString[currString.Length - 1];
                int positionLetterAfterNumb = 0;

                double number = int.Parse(inputItem.Substring(1, inputItem.Length - 2));

                double currSum = 0;

                if (Char.IsUpper(letterBeforeNumb))
                {
                    positionLetterBeforeNumb = letterBeforeNumb - 64;
                    currSum = number / positionLetterBeforeNumb;
                }
                else
                {
                    positionLetterBeforeNumb = letterBeforeNumb - 96;
                    currSum = number * positionLetterBeforeNumb;
                }

                if(Char.IsUpper(letterAfterNumb))
                {
                    positionLetterAfterNumb = letterAfterNumb - 64;
                    currSum -= positionLetterAfterNumb;
                }
                else
                {
                    positionLetterAfterNumb = letterAfterNumb - 96;
                    currSum += positionLetterAfterNumb;
                }

                totalSum += currSum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

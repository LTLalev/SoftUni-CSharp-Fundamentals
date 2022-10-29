using System;

namespace P10_MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);
            var result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(result);
        }

        private static int GetSumOfEvenDigits(int input)
        {
            int currNum = 0;
            int sum = 0;
            
            while (input != 0)
            {
                currNum = input % 10;
                
                if(currNum % 2 == 0)
                {
                    sum += currNum;
                }
                input = input / 10;
            }

            int evenSum = Math.Abs(sum);
            return evenSum;
        }

        private static int GetSumOfOddDigits(int input)
        {
            int currNum = 0;
            int sum = 0;

            while (input != 0)
            {
                currNum = input % 10;

                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
                input = input / 10;
            }

            int oddSum = Math.Abs(sum);
            return oddSum;
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;

            return result;
        }
    }
}

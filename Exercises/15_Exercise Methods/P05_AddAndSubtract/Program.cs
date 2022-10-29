using System;

namespace P05_AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int sum = CalculateSumOfFirstTwoNumb(numOne, numTwo);
            int result = CalculateSubstractThirdNumbFromSum(sum, numThree);

            Console.WriteLine(result);
        }

        static int CalculateSumOfFirstTwoNumb(int numOne, int numTwo) => numOne + numTwo;

        static int CalculateSubstractThirdNumbFromSum(int sum, int numThree) => sum - numThree;
    }
}

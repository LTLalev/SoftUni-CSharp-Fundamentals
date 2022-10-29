using System;

namespace P11_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int result = CalculateResult(numOne, oper, numTwo);
            Console.WriteLine(result);
        }

        private static int CalculateResult(int numOne, char oper, int numTwo)
        {
            int result = 0;

            if(oper == '/')
            {
                result = numOne / numTwo;
            }
            else if(oper == '*')
            {
                result = numOne * numTwo;
            }
            else if(oper == '+')
            {
                result = numOne + numTwo;
            }
            else
            {
                result = numOne - numTwo;
            }

            return result;
        }
    }
}

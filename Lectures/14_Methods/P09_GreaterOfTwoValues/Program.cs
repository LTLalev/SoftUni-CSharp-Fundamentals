using System;

namespace P09_GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();            
            
            if(inputType == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                GetMax(firstNum, secondNum);
            }
            else if(inputType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                GetMax(firstChar, secondChar);
            }
            else
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                GetMax(firstInput, secondInput);
            }

        }

        static void GetMax(string firstInput, string secondInput)
        {
            if(firstInput.CompareTo(secondInput) < 0)
            {
                Console.WriteLine(secondInput);
            }
            else
            {
                Console.WriteLine(firstInput);
            }
        }

        static void GetMax(int firstInput, int secondInput)
        {
            if (firstInput > secondInput)
            {
                Console.WriteLine(firstInput);
            }
            else
            {
                Console.WriteLine(secondInput);
            }
        }

        static void GetMax(char firstInput, char secondInput)
        {
            if (firstInput > secondInput)
            {
                Console.WriteLine(firstInput);
            }
            else
            {
                Console.WriteLine(secondInput);
            }
        }
    }
}

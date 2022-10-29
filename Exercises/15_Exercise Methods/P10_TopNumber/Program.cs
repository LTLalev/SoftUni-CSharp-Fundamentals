using System;

namespace P10_TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(DigitDivideByEight(i) == true)
                {
                    if(HaveNumberOneOddDigit(i) == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
           
        }

        static bool DigitDivideByEight(int i)
        {
            int sumOfDigit = 0;      

            while (i > 0)
            {
                sumOfDigit += i % 10;
                i /= 10;
            }
            
            if(sumOfDigit % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static bool HaveNumberOneOddDigit(int i)
        {
            bool IsHave = false;
            while (i > 0)
            {
                int currentDigit = i % 10;

                if (currentDigit % 2 != 0)
                {
                    IsHave = true;
                    return true;                    
                }

                i /= 10;
            }
            
            return IsHave;
        }
    }
}

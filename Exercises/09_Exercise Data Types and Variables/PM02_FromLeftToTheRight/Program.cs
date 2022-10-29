using System;


namespace PM02_FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfInput; i++)
            {
                string inputString = Console.ReadLine();

                string beforeChar = inputString.Substring(0, inputString.IndexOf(" "));
                long leftNum = long.Parse(beforeChar);

                string afterChar = inputString.Substring(inputString.IndexOf(" "));
                long rightNum = long.Parse(afterChar);

                long sum = 0;

                if (leftNum > rightNum)
                {
                    sum = 0;

                    while (leftNum != 0)
                    {
                        long num = leftNum % 10;
                        long currentNum = leftNum / 10;
                        leftNum = currentNum;
                        sum += num;
                    }
                }
                else
                {
                    sum = 0;

                    while (rightNum != 0)
                    {
                        long num = rightNum % 10;
                        long currentNum = rightNum / 10;
                        rightNum = currentNum;
                        sum += num;
                    }

                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}

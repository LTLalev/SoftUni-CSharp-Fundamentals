using System;

namespace PM01_SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int midleNum = 0;
            int minNum = 0;

            for (int i = 1; i <= 3; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= maxNum)
                {
                    minNum = midleNum;
                    midleNum = maxNum;
                    maxNum = n;
                }
                else if (n < maxNum)
                {
                    if (n < midleNum)
                    {
                        minNum = n;
                    }
                    else
                    {
                        minNum = midleNum;
                        midleNum = n;
                    }
                }
            }

            Console.WriteLine(maxNum);
            Console.WriteLine(midleNum);
            Console.WriteLine(minNum);
        }
    }
}

using System;

namespace PM02_PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine(1);
            if (numbOfRows > 1)
            {
                long[] secondArray = new long[2] { 1, 1 };

                Console.WriteLine(string.Join(' ', secondArray));

                for (int col = 3; col <= numbOfRows; col++)
                {
                    long sum = 0;

                    long[] array = new long[col];

                    array[0] = 1;
                    array[array.Length - 1] = 1;

                    for (int i = 0; i < secondArray.Length - 1; i++)
                    {
                        sum = secondArray[i] + secondArray[i + 1];
                        array[i + 1] = sum;
                    }
                    secondArray = array;

                    Console.WriteLine(string.Join(' ', array));
                }
            }
        }
    }
}

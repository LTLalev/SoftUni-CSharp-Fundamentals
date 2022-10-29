using System;

namespace PM04_TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int realNum = num + 2;
            int[] array = ArrayFibonacci(realNum);

            for (int i = 2; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int[] ArrayFibonacci(int realNum)
        {
            int[] array = new int[realNum];

            for (int i = 0; i < array.Length; i++)
            {
                array[0] = 0;
                array[1] = 0;
                array[2] = 1;

                if (i < 4)
                {
                    for (int j = 0; j < i; j++)
                    {

                        array[i] += array[j];
                    }
                }
                else
                {
                    for (int j = i - 3; j < i; j++)
                    {
                        array[i] += array[j];
                    }
                }
            }

            return array;
        }
    }
}

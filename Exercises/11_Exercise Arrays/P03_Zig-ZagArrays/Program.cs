using System;
using System.Linq;

namespace P03_Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] evenArr = new int[num];
            int[] oddArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if(i % 2 == 0)
                {
                    evenArr[i] = input[0];
                    oddArr[i] = input[1];
                    continue;
                }
                
                evenArr[i] = input[1];
                oddArr[i] = input[0];                                
            }

            Console.WriteLine(String.Join(' ', evenArr));
            Console.WriteLine(String.Join(' ', oddArr));
        }
    }
}

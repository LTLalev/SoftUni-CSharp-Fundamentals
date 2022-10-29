using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while(array.Length > 1)
            {     
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i] + array[i + 1];
                }

                Array.Resize(ref array, array.Length - 1);
            }

            Console.WriteLine(array[0]);
        }
    }
}

using System;
using System.Linq;

namespace P07_EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool IsDiff = false;       
            int diffIndex = -1;           

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    diffIndex = i;
                    IsDiff = true;                    
                    break;
                }                    
            }

            if(!IsDiff)
            {
                int sum = array1.Sum();
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
            }
        }
    }
}

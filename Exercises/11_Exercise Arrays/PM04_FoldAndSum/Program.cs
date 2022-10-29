using System;
using System.Linq;

namespace PM04_FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int k = array.Length / 4;
            int[] firstReverseArray = new int[k];

            Array.Copy(array, 0, firstReverseArray, 0, k);
            Array.Reverse(firstReverseArray);

            int[] secondReverseArray = new int[k];
            Array.Copy(array, array.Length - k, secondReverseArray, 0, k);
            Array.Reverse(secondReverseArray);

            int[] reverseArray = new int[array.Length / 2];
            Array.ConstrainedCopy(firstReverseArray, 0, reverseArray, 0, k);
            Array.ConstrainedCopy(secondReverseArray, 0, reverseArray, k, k);

            int endIndex = k * 2;
            int[] restNumbs = new int[array.Length / 2];
            Array.ConstrainedCopy(array, k, restNumbs, 0, endIndex);

            int[] sumArray = new int[array.Length / 2];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = reverseArray[i] + restNumbs[i];
            }

            Console.WriteLine(string.Join(' ', sumArray));
        }
    }
}

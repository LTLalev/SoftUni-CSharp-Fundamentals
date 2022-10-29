using System;
using System.Linq;

namespace PM01_EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfString = int.Parse(Console.ReadLine());
            int[] array = new int[numbersOfString];

            for (int i = 0; i < numbersOfString; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'A' || name[j] == 'a' || name[j] == 'E' || name[j] == 'e' || name[j] == 'I' || name[j] == 'i' || 
                        name[j] == 'O' || name[j] == 'o' || name[j] == 'U' || name[j] == 'u')
                    {
                        sum += name[j] * name.Length;
                    }
                    else
                    {
                        sum += name[j] / name.Length;
                    }
                }

                array[i] = sum;
            }

            Array.Sort(array);
            Console.WriteLine(String.Join('\n', array));
        }
    }
}

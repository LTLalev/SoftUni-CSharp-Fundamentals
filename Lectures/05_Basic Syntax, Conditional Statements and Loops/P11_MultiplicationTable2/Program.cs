using System;

namespace P11_MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {multiplier * num}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");

                }

            }
        }
    }
}

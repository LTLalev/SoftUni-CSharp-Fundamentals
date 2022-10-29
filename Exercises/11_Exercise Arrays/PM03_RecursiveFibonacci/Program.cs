using System;

namespace PM03_RecursiveFibonacci
{
    internal class Program
    {
        static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return (fib(n - 1) + fib(n - 2));
            }

        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(fib(n));
        }
    }
}

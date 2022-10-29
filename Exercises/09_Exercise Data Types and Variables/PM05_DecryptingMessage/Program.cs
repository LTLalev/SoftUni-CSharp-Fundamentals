using System;

namespace PM05_DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 1; i <= lines; i++)
            {
                char inputs = char.Parse(Console.ReadLine());

                char outputs = (char)(inputs + key);
                result += outputs;
            }

            Console.WriteLine(result);

        }
    }
}

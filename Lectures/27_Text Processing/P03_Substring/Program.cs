using System;

namespace P03_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(str))
            {
                int startIndex = text.IndexOf(str);
                int lengthRemove = str.Length;
                text = text.Remove(startIndex, lengthRemove);
            }

            Console.WriteLine(text);
        }
    }
}

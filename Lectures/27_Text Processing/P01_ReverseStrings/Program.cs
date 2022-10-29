using System;

namespace P01_ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while (word != "end")
            {
                string reverseWord = string.Empty;
                
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }

                Console.WriteLine($"{word} = {reverseWord}");

                word = Console.ReadLine();
            }
        }
    }
}

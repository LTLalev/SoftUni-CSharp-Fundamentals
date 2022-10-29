using System;
using System.Linq;

namespace P03_CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());

           PrintChars(charOne, charTwo);
        }

        static void PrintChars(char charOne, char charTwo)
        {
            if (charTwo < charOne)
            {
                for (int i = charTwo + 1; i < charOne; i++)
                {
                    Console.Write($"{Convert.ToChar(i)} ");
                }
            }
            else
            {
                for (int i = charOne + 1; i < charTwo; i++)
                {
                    Console.Write($"{Convert.ToChar(i)} ");
                }
            }
        }
    }
}

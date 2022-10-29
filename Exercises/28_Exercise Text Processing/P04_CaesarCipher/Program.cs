using System;
using System.Linq;

namespace P04_CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encriptText = string.Empty;

            foreach (char c in text)
            {
                encriptText += Convert.ToChar(c + 3);
            }

            Console.WriteLine(encriptText);
        }
    }
}

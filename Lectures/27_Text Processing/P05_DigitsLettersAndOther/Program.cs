using System;
using System.Text;

namespace P05_DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            StringBuilder letter = new StringBuilder();
            StringBuilder digit = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (char c in input)
            {
                if(char.IsLetter(c))
                {
                    letter.Append(c);
                }
                else if(char.IsDigit(c))
                {
                    digit.Append(c);
                }
                else
                {
                    other.Append(c);
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);
        }
    }
}

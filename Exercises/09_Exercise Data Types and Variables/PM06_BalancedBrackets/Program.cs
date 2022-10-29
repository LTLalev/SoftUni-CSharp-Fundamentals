using System;

namespace P06_BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());

            string output = string.Empty;
            bool isUnbalanced = false;

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();

                char valueFirst = '(';
                char valueSecond = ')';

                bool result = input.Contains(valueFirst);
                bool result2 = input.Contains(valueSecond);

                if (result || result2)
                {
                    output += input;

                    if (output == "()")
                    {
                        isUnbalanced = true;
                        output = string.Empty;
                    }
                    else
                    {
                        isUnbalanced = false;
                    }
                }
            }

            if (isUnbalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}

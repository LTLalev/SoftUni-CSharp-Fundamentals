using System;
using System.Text;

namespace P07_StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            int bombPower = 0;
            bool IsBomb = false;

            foreach (var ch in text)
            {
                if(IsBomb == true)
                {
                    if(char.IsDigit(ch))
                    {
                        bombPower += Convert.ToChar(ch - 48);
                        IsBomb = false;
                        bombPower--;
                        continue;
                    }
                    else
                    {
                        result.Append(ch);
                    }
                }

                if(ch == '>')
                {
                    IsBomb = true;
                    result.Append(ch);
                    continue;
                }
                
                if(bombPower > 0)
                {
                    bombPower--;
                    continue;
                }

                result.Append(ch);

                if(bombPower > 0)
                {
                    bombPower--;
                }
            }

            Console.WriteLine(result);
        }
    }
}

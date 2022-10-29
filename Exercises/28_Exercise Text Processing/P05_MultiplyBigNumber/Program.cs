using System;
using System.Text;

namespace P05_MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bigNumber = Console.ReadLine();
            var littleNumber = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int num = Convert.ToInt32(bigNumber[i]) - 48;
                int res = num * littleNumber + remainder;
                remainder = 0;

                if(res > 9)
                {
                    int tens = res % 10;
                    remainder = res / 10;
                    result.Insert(0, tens.ToString());
                }
                else
                {
                    result.Insert(0, res);
                }
            }

            if(remainder > 0)
            {
                result.Insert(0, remainder);
            }

            if(littleNumber == 0 || bigNumber == "0")
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

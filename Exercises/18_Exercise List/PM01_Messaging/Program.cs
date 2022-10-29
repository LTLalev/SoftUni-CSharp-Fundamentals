using System;
using System.Collections.Generic;
using System.Linq;

namespace PM01_Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();    
           
            string text = Console.ReadLine();
            List<char> textList = text.ToList();
            string result = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                string currNumb = numbers[i].ToString();
                List<string> currNumArray = new List<string>();

                for (int j = 0; j < currNumb.Length; j++)
                {
                    currNumArray.Add(currNumb[j].ToString());
                }

                List<int> numArray = currNumArray.Select(int.Parse).ToList();
                int sum = numArray.Sum();

                if (sum > textList.Count)
                {
                    int diff = sum - textList.Count;
                    result += textList.ElementAt(diff);
                    textList.RemoveAt(diff);
                }
                else
                {
                    result += textList.ElementAt(sum);
                    textList.RemoveAt(sum);
                }
            }

            Console.WriteLine(result);
        }
    }
}

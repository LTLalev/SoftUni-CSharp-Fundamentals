using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List <string> reversArray = new List <string>();           

            for (int i = inputs.Count - 1; i >= 0 ; i--)
            {
                string array = inputs[i];
                
                List<string> newArr = array.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                
                foreach(var number in newArr)
                {
                    reversArray.Add(number);
                }
            }          

            Console.WriteLine(string.Join(' ', reversArray));
        }
    }
}

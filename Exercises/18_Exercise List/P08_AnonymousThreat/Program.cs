using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputs = Console.ReadLine();
            
            while (inputs != "3:1")
            {
                string[] commandsArgm = inputs
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandsArgm[0];

                if(command == "merge")
                {
                    MergeElements(input, commandsArgm);                   
                }
                else
                {
                    DivideElements(input, commandsArgm);                   
                }

                inputs = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', input));
        }

        static void MergeElements(List<string> input, string[] commandsArgm)
        {
            int startIndex = int.Parse(commandsArgm[1]);
            int endIndex = int.Parse(commandsArgm[2]);

            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex > input.Count - 1 ? input.Count - 1 : endIndex;

            for (int count = startIndex + 1; count <= endIndex; count++)
            {             
                input[startIndex] += input[startIndex + 1];
                input.RemoveAt(startIndex + 1);
            }
        }

        static void DivideElements(List<string> input, string[] commandsArgm)
        {
            int index = int.Parse(commandsArgm[1]);
            int partition = int.Parse(commandsArgm[2]);                     

            string currPart = input[index].ToString();
            input.RemoveAt(index);
            int finalLength = currPart.Length;
            int realPart = finalLength / partition;
            string copyCurrPart = currPart;

            for (int i = 0; i < finalLength; i += realPart)
            {
                if (partition == 0)
                {
                    break;
                }

                input.Insert(index, currPart.Substring(i, realPart));
                copyCurrPart = copyCurrPart.Remove(0, realPart);
                index++;
                partition--;
            }

            if (copyCurrPart.Length > 0)
            {
                input[index - 1] += copyCurrPart;
            }
        }
    }
}

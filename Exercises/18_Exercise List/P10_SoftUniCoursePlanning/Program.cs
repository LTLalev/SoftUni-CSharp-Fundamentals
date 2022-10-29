using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string inputArgm = Console.ReadLine();

            while (inputArgm != "course start")
            {
                string[] inputsArgm = inputArgm
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = inputsArgm[0];
                string lessonTitle = inputsArgm[1];

                if (command == "Add")
                {
                    AddLessons(input, inputsArgm, lessonTitle);
                    
                }
                else if(command == "Insert")
                {
                    InsertLessons(input, inputsArgm, lessonTitle);                    
                }
                else if(command == "Remove")
                {
                    RemoveLessons(input, inputsArgm, lessonTitle);                    
                }
                else if(command == "Swap")
                {
                    string lessonTitle2 = inputsArgm[2];

                    if (input.Contains(lessonTitle2) && input.Contains(lessonTitle))
                    {
                        SwapLessons(input, inputsArgm, lessonTitle, lessonTitle2);             
                    }

                    if(input.Contains($"{lessonTitle}-Exercise") || input.Contains($"{lessonTitle2}-Exercise"))
                    {
                        SwapExercises(input, inputsArgm, lessonTitle, lessonTitle2);
                    }
                }
                else if(command == "Exercise")
                {
                    AddExercises(input, inputsArgm, lessonTitle);                   
                }

                inputArgm = Console.ReadLine();
            }

            int indexLessons = 1;
            foreach (var item in input)
            {
                Console.Write($"{indexLessons}.");
                Console.WriteLine(item);
                indexLessons++;
            }
        }

        private static void AddExercises(List<string> input, string[] inputsArgm, string lessonTitle)
        {
            if (input.Contains(lessonTitle) && input.Contains($"{lessonTitle}-Exercise") == false)
            {
                int lessonTitleIndex = input.IndexOf(lessonTitle);
                input.Insert(lessonTitleIndex + 1, $"{lessonTitle}-Exercise");
            }
            else if (input.Contains(lessonTitle) == false)
            {
                input.Add(lessonTitle);
                input.Add($"{lessonTitle}-Exercise");
            }
        }

        private static void SwapLessons(List<string> input, string[] inputsArgm, string lessonTitle, string lessonTitle2)
        {
            int index = input.IndexOf(lessonTitle);
            int swapIndex = input.IndexOf(lessonTitle2);

            string tmp = input[index];
            input[index] = input[swapIndex];
            input[swapIndex] = tmp;
        }   
           
        private static void SwapExercises(List<string> input, string[] inputsArgm, string lessonTitle, string lessonTitle2)
        {
            if (input.Contains($"{lessonTitle}-Exercise"))
            {
                int indexToMove = input.IndexOf(lessonTitle);
                int index = input.IndexOf($"{lessonTitle}-Exercise");
                input.Insert(indexToMove + 1, input[index]);
                input.RemoveAt(index);
            }

            if (input.Contains($"{lessonTitle2}-Exercise"))
            {
                int indexToMove = input.IndexOf(lessonTitle2);
                int index = input.IndexOf($"{lessonTitle2}-Exercise");
                string tmp = input[index];
                input.RemoveAt(index);
                input.Insert(indexToMove + 1, tmp);
            }
        }          

        private static void RemoveLessons(List<string> input, string[] inputsArgm, string lessonTitle)
        { 
            if (input.Contains(lessonTitle))
            {
                input.Remove(lessonTitle);
            }

            if (input.Contains($"{lessonTitle}-Exercise"))
            {
                input.Remove($"{lessonTitle}-Exercise");
            }
        }

        private static void InsertLessons(List<string> input, string[] inputsArgm, string lessonTitle)
        {            
            int index = int.Parse(inputsArgm[2]);

            if (!input.Contains(lessonTitle))
            {
                input.Insert(index, lessonTitle);
            }
        }

        private static void AddLessons(List<string> input, string[] inputsArgm, string lessonTitle)
        {
            if (!input.Contains(lessonTitle))
            {
                input.Add(lessonTitle);
            }
        }
    }
}

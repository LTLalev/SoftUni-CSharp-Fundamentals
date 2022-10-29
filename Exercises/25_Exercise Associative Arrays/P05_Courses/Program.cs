using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Courses
{
    internal class Program
    {
        public static object Dictionaty { get; private set; }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string courseName = inputArgm[0];
                string studentName = inputArgm[1];

                if(!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var kvp in courses)
            {
                int countOfStudentsInCourse = kvp.Value.Count();
                string courseName = kvp.Key;

                Console.WriteLine($"{courseName}: {countOfStudentsInCourse}");

                foreach (var course in courses[courseName])
                {
                    string studentName = course;

                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}

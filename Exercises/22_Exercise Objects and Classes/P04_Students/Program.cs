using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Students
{
    class Student
    {
        public Student(string str1, string str2, string db)
        {
            this.FirstName = str1;
            this.LastName = str2;
            this.Grade = db;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfAllStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfAllStudent; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = input[0];
                string lastName = input[1];
                string grade = input[2];

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            foreach (var item in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(item);
            }
        }
    }
}

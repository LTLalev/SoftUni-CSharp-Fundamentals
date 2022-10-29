using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Students
{   
    internal class Program
    {       
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = inputArgm[0];
                string lastName = inputArgm[1];
                int age = int.Parse(inputArgm[2]);
                string homeTown = inputArgm[3];

                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<Student> filtredStudents = students.FindAll(students => students.HomeTown == input);

            foreach (Student student in filtredStudents)
            {
                string firstName = student.FirstName;
                string lastName = student.LastName;
                int age = student.Age;

                Console.WriteLine($"{firstName} {lastName} is {age} years old.");
            }
        }

        class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}

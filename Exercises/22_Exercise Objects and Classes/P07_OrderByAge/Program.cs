using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_OrderByAge
{
    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputArgm[0];
                int Id = int.Parse(inputArgm[1]);
                int age = int.Parse(inputArgm[2]);

                if(persons.Any(x => x.Id == Id))
                {
                    foreach (var per in persons.Where(x => x.Id == Id))
                    {
                        per.Age = age;
                        per.Name = name;
                    }
                    
                }
                else
                {
                    Person person = new Person(name, Id, age);
                    persons.Add(person);
                }

                input = Console.ReadLine();
            }

            foreach (var human in persons.OrderBy(x => x.Age))
            {
                string name = human.Name;
                int Id = human.Id;
                int age = human.Age;

                Console.WriteLine($"{name} with ID: {Id} is {age} years old.");
            }
        }
    }
}

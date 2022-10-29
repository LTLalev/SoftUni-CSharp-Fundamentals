using System;
using System.Collections.Generic;
using System.Linq;

namespace PM02_OldestFamilyMember
{
    class Family
    {
        public Family()
        {
            Persons = new List<Person>();       
        }
        public List<Person> Persons { get; set; }

        public void AddMember(Person person)
        {
            Persons.Add(person);
        }
        public Person GetOldestMember(Family person)
        {
            int maxAge = person.Persons.Max(x => x.Age);
            var name = person.Persons.Find(x => x.Age == maxAge);

            return name;
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family persons = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                persons.AddMember(person);                
            }

            var oldestPerson = persons.GetOldestMember(persons);

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}

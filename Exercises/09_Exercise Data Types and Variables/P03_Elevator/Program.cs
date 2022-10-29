using System;

namespace P03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)numberOfPeople / capacityOfPersons);

            Console.WriteLine(courses);
        }
    }
}

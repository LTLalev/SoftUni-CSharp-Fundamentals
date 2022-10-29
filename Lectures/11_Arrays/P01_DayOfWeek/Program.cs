using System;
using System.Linq;

namespace P01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int input = int.Parse(Console.ReadLine());

            if(input > 0 && input < 8)
            {
                Console.WriteLine($"{weekDays[input - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

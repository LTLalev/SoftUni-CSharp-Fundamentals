using System;

namespace P04_BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 30;

            if (newMinutes > 59)
            {
                hours++;
                newMinutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{newMinutes:D2}");
        }
    }
}

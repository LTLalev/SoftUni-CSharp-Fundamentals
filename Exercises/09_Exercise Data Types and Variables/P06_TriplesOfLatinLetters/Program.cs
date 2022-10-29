using System;

namespace P06_TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < 'a' + n; firstLetter++)
            {
                for (char seconLetter = 'a'; seconLetter < 'a' + n; seconLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + n; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{seconLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}

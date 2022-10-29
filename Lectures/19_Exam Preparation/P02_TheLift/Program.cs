using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> currentLiftState = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxPeopleOnWagon = 4;
            int totalPeopleIn = 0;
            int maxCountPeopleIn = maxPeopleOnWagon * currentLiftState.Count;
            int occupiedСeats = currentLiftState.Sum();

            //bool IsPeopleNull = false;
            //bool IsNoSpace = false;
            //bool IsLiftFull = false;

            for (int i = 0; i < currentLiftState.Count; i++)
            {
                if (currentLiftState[i] < maxPeopleOnWagon)
                {
                    if(people < maxPeopleOnWagon)
                    {
                        currentLiftState[i] += people;
                        totalPeopleIn += people;
                        people -= people;
                        break;
                    }

                    int peopleIn = maxPeopleOnWagon - currentLiftState[i];
                    currentLiftState[i] += peopleIn;
                    totalPeopleIn += peopleIn;
                    people -= peopleIn;
                }
            }

            int seatsLeft = maxCountPeopleIn - totalPeopleIn - occupiedСeats;

            if(people <= 0 && seatsLeft > 0)
            {
                Console.WriteLine($"The lift has empty spots!" + '\n' +
                    $"{string.Join(' ', currentLiftState)}");
            }
            else if(people > 0 && seatsLeft <= 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!" + '\n' +
                    $"{string.Join(' ', currentLiftState)}");
            }
            else if (people <= 0 && seatsLeft <= 0)
            {
                Console.WriteLine(string.Join(" ", currentLiftState));
            }
        }
    }
}

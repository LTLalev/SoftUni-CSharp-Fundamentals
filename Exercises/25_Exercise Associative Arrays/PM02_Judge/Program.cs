using System;
using System.Collections.Generic;
using System.Linq;

namespace PM02_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> studentsPoints = new Dictionary<string, Dictionary<string, int>>();            

            while (input != "no more time")
            {
                string[] inputArgm = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = inputArgm[0];
                var contest = inputArgm[1];
                var points = int.Parse(inputArgm[2]);

                AddInputArgm(students, name, contest, points);               

                CalculateEachStudentTotalPoints(studentsPoints, name, contest, points);                

                input = Console.ReadLine();
            }

            PrintContest(students);

            PrintIndividuaPoints(studentsPoints);           
        }

        private static void CalculateEachStudentTotalPoints(Dictionary<string, Dictionary<string, int>> studentsPoints, string name, string contest, int points)
        {
            if (studentsPoints.ContainsKey(name))
            {
                if (studentsPoints[name].ContainsKey(contest))
                {
                    if (studentsPoints[name][contest] < points)
                    {
                        studentsPoints[name][contest] = points;
                    }
                }
                else
                {
                    studentsPoints[name].Add(contest, points);
                }
            }
            else
            {
                studentsPoints.Add(name, new Dictionary<string, int>());
                studentsPoints[name].Add(contest, points);
            }
        }

        private static void AddInputArgm(Dictionary<string, Dictionary<string, int>> students, string name, string contest, int points)
        {
            if (!students.ContainsKey(contest))
            {
                students.Add(contest, new Dictionary<string, int>());
                students[contest].Add(name, points);
            }
            else
            {
                if (!students[contest].ContainsKey(name))
                {
                    students[contest].Add(name, points);
                }
                else
                {
                    if (students[contest][name] < points)
                    {
                        students[contest][name] = points;
                    }
                }
            }
        }

        static void PrintContest(Dictionary<string, Dictionary<string, int>> students)
        {

            foreach (var contest in students)
            {
                var contestName = contest.Key;
                var participantsCount = contest.Value.Count;
                var position = 1;

                Console.WriteLine($"{contestName}: {participantsCount} participants");

                foreach (var kvp in students[contestName].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    var username = kvp.Key;
                    var points = kvp.Value;

                    Console.WriteLine($"{position}. {username} <::> {points}");
                    position++;
                }
            }
        }

        static void PrintIndividuaPoints(Dictionary<string, Dictionary<string, int>> studentsPoints)
        {
            Console.WriteLine("Individual standings:");
            int position = 1;

            foreach (var kvp in studentsPoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                var username = kvp.Key;
                var totalPoints = kvp.Value.Values.Sum();

                Console.WriteLine($"{position}. {username} -> {totalPoints}");
                position++;
            }
        }
    }
}

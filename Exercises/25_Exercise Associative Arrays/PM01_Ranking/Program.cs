using System;
using System.Collections.Generic;
using System.Linq;

namespace PM01_Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] inputArgm = input
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contest = inputArgm[0];
                string password = inputArgm[1];

                dictionary.Add(contest, password);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> filtredDictionary = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of submissions")
            {
                string[] inputArgm = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contest = inputArgm[0];
                string pass = inputArgm[1];
                string username = inputArgm[2];
                int points = int.Parse(inputArgm[3]);

                if(dictionary.ContainsKey(contest) && dictionary[contest].Contains(pass))
                {
                    if(!filtredDictionary.ContainsKey(username))
                    {
                        filtredDictionary.Add(username, new Dictionary<string, int>());
                        filtredDictionary[username].Add(contest, points);
                    }
                    else
                    {
                        if (filtredDictionary[username].ContainsKey(contest))
                        {
                            if(filtredDictionary[username][contest] < points)
                            {
                                filtredDictionary[username][contest] = points;
                            }
                        }
                        else
                        {
                            filtredDictionary[username].Add(contest, points);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            string bestCandidate = null;
            int totalPoint = 0;

            foreach (var user in filtredDictionary)
            {
                string name = user.Key;
                int points = 0;

                foreach (var contest in filtredDictionary[name])
                {
                    points += contest.Value;

                    if(points > totalPoint)
                    {
                        totalPoint = points;
                        bestCandidate = name;
                    }
                }               
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoint} points.");
            Console.WriteLine("Ranking:");            

            foreach (var kvp in filtredDictionary.OrderBy(x => x.Key))
            {
                string name = kvp.Key;

                Console.WriteLine($"{name}");

                foreach (var contest in filtredDictionary[name].OrderByDescending(x => x.Value))
                {
                    var cont = contest.Key;
                    var points = contest.Value;

                    Console.WriteLine($"#  {cont} -> {points}");
                }
            }
        }
    }
}

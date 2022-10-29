using System;
using System.Collections.Generic;
using System.Linq;

namespace PM03_MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> map = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputArgm[1] == "->")
                {
                    AddPlayer(inputArgm, input, map);                    
                }
                else
                {
                    DuelPlayer(inputArgm, input, map);                    
                }

                input = Console.ReadLine();
            }

            PrintPlayers(map);            
        }

        private static void PrintPlayers(Dictionary<string, Dictionary<string, int>> map)
        {
            foreach (var player in map.OrderByDescending(x => x.Value.Sum(x => x.Value)).ThenBy(x => x.Key))
            {
                int totalSkill = player.Value.Sum(x => x.Value);
                string name = player.Key;

                Console.WriteLine($"{name}: {totalSkill} skill");

                foreach (var kvp in map[name].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string position = kvp.Key;
                    int skill = kvp.Value;

                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }

        private static void DuelPlayer(string[] inputArgm, string input, Dictionary<string, Dictionary<string, int>> map)
        {
            inputArgm = input
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

            string player1 = inputArgm[0];
            string player2 = inputArgm[1];

            if (map.ContainsKey(player1) && map.ContainsKey(player2))
            {
                bool TheyHaveCommonPosition = false;
               
                foreach (var position in map[player1])
                {
                    foreach (var pos in map[player2])
                    {
                        if (position.Key == pos.Key)
                        {
                            TheyHaveCommonPosition = true;
                            break;
                        }
                    }
                }

                if (TheyHaveCommonPosition)
                {
                    int totalSkillPointPlayer1 = map[player1].Sum(x => x.Value);
                    int totalSkillPointPlayer2 = map[player2].Sum(x => x.Value);

                    if (totalSkillPointPlayer1 > totalSkillPointPlayer2)
                    {
                        map.Remove(player2);
                    }
                    else
                    {
                        map.Remove(player1);
                    }

                }
            }
        }

        private static void AddPlayer(string[] inputArgm, string input, Dictionary<string, Dictionary<string, int>> map)
        {
            inputArgm = input
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string player = inputArgm[0];
                string position = inputArgm[1];
                int skill = int.Parse(inputArgm[2]);

                if(!map.ContainsKey(player))
                {
                    map.Add(player, new Dictionary<string, int>());
                    map[player].Add(position, skill);
                }
                else
                {
                    if (!map[player].ContainsKey(position))
                    {
                        map[player].Add(position, skill);
                    }
                    else
                    {
                        if (map[player][position] < skill)
                        {
                            map[player][position] = skill;
                        }
                    }
                }
        }
    }
}

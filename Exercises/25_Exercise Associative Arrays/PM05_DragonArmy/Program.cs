using System;
using System.Collections.Generic;
using System.Linq;

namespace PM05_DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> dragons = new Dictionary<string, List<int>>();

            for (int dragonCount = 0; dragonCount < numberOfDragons; dragonCount++)
            {
                string[] inputArgm = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = inputArgm[0];
                string name = inputArgm[1];
                string damage = inputArgm[2];
                string health = inputArgm[3];
                string armor = inputArgm[4];

                string ID = type + ' ' + name;

                if (dragons.ContainsKey(ID))
                {
                    UpdateDragon(dragons, ID, damage, health, armor);
                }
                else
                {
                    AddNewDragon(dragons, ID, damage, health, armor);
                }
            }

            PrintData(dragons);
        }

        private static void PrintData(Dictionary<string, List<int>> dragons)
        {
            List<string> printTypes = new List<string>();

            foreach (var type in dragons)
            {
                string types = type.Key.Split(' ')[0];

                if (!printTypes.Contains(types))
                {
                    printTypes.Add(types);
                    int damages = 0;
                    int healths = 0;
                    int armors = 0;

                    foreach (var stats in dragons.Where(x => x.Key.Split(' ')[0] == types))
                    {
                        damages += stats.Value[0];
                        healths += stats.Value[1];
                        armors += stats.Value[2];
                    }

                    int count = dragons.Where(x => x.Key.Split(' ')[0] == types).Count();

                    double averageDamage = (double)damages / count;
                    double averageHealth = (double)healths / count;
                    double averageArmor = (double)armors / count;

                    Console.WriteLine($"{type.Key.Split(' ')[0]}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                    foreach (var names in dragons.Where(x => x.Key.Split(' ')[0] == types).OrderBy(x => x.Key.Split(' ')[1]))
                    {
                        string name = names.Key.Split(' ')[1];
                        int damage = names.Value[0];
                        int health = names.Value[1];
                        int armor = names.Value[2];

                        Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                    }
                }
            }
        }
        private static void AddNewDragon(Dictionary<string, List<int>> dragons, string ID, string damage, string health, string armor)
        {
            if (damage == "null")
            {
                damage = 45.ToString();
            }

            if (health == "null")
            {
                health = 250.ToString();
            }

            if (armor == "null")
            {
                armor = 10.ToString();
            }

            dragons.Add(ID, new List<int>());
            dragons[ID].Add(int.Parse(damage));
            dragons[ID].Add(int.Parse(health));
            dragons[ID].Add(int.Parse(armor));
        }

        private static void UpdateDragon(Dictionary<string, List<int>> dragons, string ID, string damage, string health, string armor)
        {
            if (damage == "null")
            {
                damage = 45.ToString();
            }

            if (health == "null")
            {
                health = 250.ToString();
            }

            if (armor == "null")
            {
                armor = 10.ToString();
            }

            dragons[ID][0] = int.Parse(damage);
            dragons[ID][1] = int.Parse(health);
            dragons[ID][2] = int.Parse(armor);
        }
    }
}

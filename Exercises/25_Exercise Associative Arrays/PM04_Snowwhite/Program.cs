using System;
using System.Collections.Generic;
using System.Linq;

namespace PM04_Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // THIS CODE NOT ORDERING CORRECT

            var input = Console.ReadLine();
            
            var colors = new Dictionary<string, Dictionary<string, int>> ();  

            while (input != "Once upon a time")
            {
                string[] inputArgm = input
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputArgm[0];
                string color = inputArgm[1];
                int physics = int.Parse(inputArgm[2]);

                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                    colors[color].Add(name, physics);
                }
                else
                {
                    if (!colors[color].ContainsKey(name))
                    {
                        colors[color].Add(name, physics);
                    }
                    else
                    {
                        if(colors[color][name] < physics)
                        {
                            colors[color][name] = physics;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in colors.OrderByDescending(x => x)
                .ThenByDescending(x => x.Key.Count()))
            {
                string color = kvp.Key;

                foreach (var kvp2 in colors[color])
                {
                    string name = kvp2.Key;
                    int physics = kvp2.Value;

                    Console.WriteLine($"({color}) {name} <-> {physics}");
                }
            }


            ///WORKING CODE

            //Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            //string input = Console.ReadLine();

            //while (input != "Once upon a time")
            //{
            //    string[] inputArgm = input
            //        .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();

            //    string dwarfName = inputArgm[0];
            //    string dwarfHatColor = inputArgm[1];
            //    int dwarfPhysics = int.Parse(inputArgm[2]);

            //    string ID = dwarfName + ' ' + dwarfHatColor;

            //    if (!dwarfs.ContainsKey(ID))
            //    {
            //        dwarfs.Add(ID, dwarfPhysics);
            //    }
            //    else
            //    {
            //        dwarfs[ID] = Math.Max(dwarfs[ID], dwarfPhysics);
            //    }

            //    input = Console.ReadLine();
            //}

            //foreach (var dwarf in dwarfs
            //    .OrderByDescending(x => x.Value)
            //    .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(' ')[1] == x.Key.Split(' ')[1])
            //                                 .Count()))
            //{
            //    string hatColor = dwarf.Key.Split(' ')[1];
            //    string name = dwarf.Key.Split(' ')[0];
            //    int physics = dwarf.Value;
            //    Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] inputArgm = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string companyName = inputArgm[0];
                string employeeId = inputArgm[1];

                if(!map.ContainsKey(companyName))
                {
                    map.Add(companyName, new List<string>());
                    map[companyName].Add(employeeId);
                }
                else
                {
                    if (!map[companyName].Contains(employeeId))
                    {
                        map[companyName].Add(employeeId);
                    }
                }               

                input = Console.ReadLine();
            }

            foreach (var kvp in map)
            {
                string company = kvp.Key;

                Console.WriteLine($"{company}");

                foreach (var employee in map[company])
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}

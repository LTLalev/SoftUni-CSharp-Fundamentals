using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommand = int.Parse(Console.ReadLine());

            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] commandArgm = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandArgm[0];
                string name = commandArgm[1];

                if(command == "register")
                {
                    string licenseNumber = commandArgm[2];

                    if (register.ContainsKey(name) && register[name].Contains(licenseNumber))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                    else
                    {
                        register.Add(name, licenseNumber);
                        Console.WriteLine($"{name} registered {licenseNumber} successfully");
                    }                   
                }
                else
                {
                    if(!register.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        register.Remove(name);
                    }
                }
            }

            foreach (var kvp in register)
            {
                string username = kvp.Key;
                string licensePlateNumber = kvp.Value;
                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}

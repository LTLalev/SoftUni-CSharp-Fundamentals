using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> register = new Dictionary<string, List<double>>();

            for (int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!register.ContainsKey(studentName))
                {
                    register.Add(studentName, new List<double>());
                }

                register[studentName].Add(grade);
            }         

            foreach (var kvp in register)
            {
                string user = kvp.Key;
                double averageGrade = kvp.Value.Average();
                
                if(averageGrade >= 4.50)
                {
                    Console.WriteLine($"{user} -> {averageGrade:f2}");
                }
            }           
        }
    }
}

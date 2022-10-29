using System;
using System.Collections.Generic;
using System.Linq;

namespace PM01_CompanyRoster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];

                if(!departments.Contains(department))
                {
                    departments.Add(department);
                }

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }

            double averageSalary = 0;
            double biggestAverageSalary = double.MinValue;
            string hightAverageSalaryDepatment = string.Empty;

            for (int i = 0; i < departments.Count; i++)
            {
                string currDepartment = departments[i];

                averageSalary = employees.Where(x => x.Department == currDepartment).Average(x => x.Salary);

                if(biggestAverageSalary < averageSalary)
                {
                    biggestAverageSalary = averageSalary;
                    hightAverageSalaryDepatment = currDepartment;
                }
            }

            Console.WriteLine($"Highest Average Salary: {hightAverageSalaryDepatment}");

            foreach (var item in employees.FindAll(x => x.Department == hightAverageSalaryDepatment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }
}

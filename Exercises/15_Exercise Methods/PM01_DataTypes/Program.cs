using System;

namespace PM01_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if(input == "int")
            {                
                int number = int.Parse(Console.ReadLine());
               
                PrintResult(number);               
            }
            else if(input == "real")
            {                
                double number = double.Parse(Console.ReadLine());

                PrintResult(number);
            }
            else
            {                
                string inputArgm = Console.ReadLine();
                
                PrintResult(inputArgm);
            }            
        }

        static void PrintResult(int number)
        {
            var result = 0.0;
            result = number * 2;
            Console.WriteLine($"{result}");
        }
        
        static void PrintResult(double number)
        {
            var result = 0.0;
            result = number * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void PrintResult(string inputArgm)
        {
            var result = string.Empty;
            Console.WriteLine($"${inputArgm}$");
        }
    }
}

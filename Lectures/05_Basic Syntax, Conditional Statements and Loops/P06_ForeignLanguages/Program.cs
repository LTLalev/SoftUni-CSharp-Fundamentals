using System;

namespace P06_ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string languige = Console.ReadLine().ToLower();

            switch (languige)
            {
                case "england":
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

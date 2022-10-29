using System;
using System.Linq;

namespace P01_ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var str in userNames)
            {
                bool IsValid = true;

                if(str.Length >= 3 && str.Length <= 16)
                {
                    foreach (var c in str)
                    {
                        if(!char.IsLetter(c) && !char.IsDigit(c) && c != '-' && c != '_')
                        {
                            IsValid = false;
                            break;
                        }
                    }

                    if(IsValid)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
        }
    }
}

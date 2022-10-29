using System;
using System.Text;

namespace P05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            StringBuilder password = new StringBuilder();
            bool IsCorrectPassword = false;

            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password.Append(username[reverseIndex]);
            }

            string newPassword = password.ToString();

            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();

                if (input == newPassword)
                {
                    IsCorrectPassword = true;
                    break;
                }
                else if (i == 4)
                {
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            if (IsCorrectPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}

using System;

namespace P11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            for (int i = 1; i <= numbersOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double price = ((days * capsuleCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

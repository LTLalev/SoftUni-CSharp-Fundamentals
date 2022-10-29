using System;

namespace P01_GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double guineasWeight = double.Parse(Console.ReadLine());

            double foodInGr = quantityFood * 1000;
            double hayInGr = quantityHay * 1000;
            double coverInGr = quantityCover * 1000;
            double weightInGr = guineasWeight * 1000;

            int totalMouthDays = 30;
            double foodPerDay = 300;
            bool IsFoodRunsOut = false;

            for (int days = 1; days <= totalMouthDays; days++)
            {        
                foodInGr -= foodPerDay;

                if(days % 2 == 0)
                {
                    double petsHay = foodInGr * 0.05;          
                    hayInGr -= petsHay;
                }

                if(days % 3 == 0)
                {
                    double puppyCover = weightInGr / 3;
                    coverInGr -= puppyCover;
                }  
                
                if(foodInGr <= 0 || hayInGr <= 0 || coverInGr <= 0)
                {
                    IsFoodRunsOut=true;
                    break;
                }
            }

            double foodInKg = foodInGr / 1000;
            double hayInKg = hayInGr / 1000;
            double coverInKg = coverInGr / 1000;            

            if(IsFoodRunsOut)
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:f2}, Hay: {hayInKg:f2}, Cover: {coverInKg:f2}.");
            }
        }
    }
}

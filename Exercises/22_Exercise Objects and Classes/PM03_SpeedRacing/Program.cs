using System;
using System.Collections.Generic;
using System.Linq;

namespace PM03_SpeedRacing
{
    class Car
    {        
        public Car(string model, double fuelAmount, double fuelConsumation)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsPerKm = fuelConsumation;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsPerKm { get; set; }
        public double Distance { get; set; }

        public bool IsCarCanMove(double neededFuel, double fuelAmount)
        {
            if(fuelAmount >= neededFuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {              
                string[] inputArgm = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = inputArgm[0];
                int fuelAmount = int.Parse(inputArgm[1]);
                double fuelConsPerKm = double.Parse(inputArgm[2]);

                Car car = new Car(model, fuelAmount, fuelConsPerKm);
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();               

                string carModel = inputArgm[1];
                int amountOfKm = int.Parse(inputArgm[2]);

                double fuelConsum = cars.Find(x => x.Model == carModel).FuelConsPerKm;
                double fuelAmount = cars.Find(x => x.Model == carModel).FuelAmount;
                double neededFuel = fuelConsum * amountOfKm;

                bool IsCarMove = false;

                foreach (var car in cars.Where(x => x.Model == carModel))
                {
                    IsCarMove = car.IsCarCanMove(neededFuel, fuelAmount);
                }

                if(IsCarMove)
                {
                    foreach (var car in cars.Where(x => x.Model == carModel))
                    {
                        car.Distance += amountOfKm;
                        car.FuelAmount -= neededFuel;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");                    
                }

                input = Console.ReadLine();
            }

            foreach ( var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}

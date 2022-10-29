using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_VehicleCatalogue
{
    class Car
    {
        public Car(string model, string color, int power)
        {
            this.model = model;
            this.color = color;
            this.power = power;
        }

        public string model { get; set; }
        public string color { get; set; }
        public int power { get; set; }
    }

    class Truck
    {
        public Truck(string model, string color, int power)
        {
            this.model = model;
            this.color = color;
            this.power = power;
        }

        public string model { get; set; }
        public string color { get; set; }
        public int power { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {          
            string input = Console.ReadLine();
            
            Catalog catalog = new Catalog();

            while (input != "End")
            {
                string[] inputArgm = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeOfVehicle = inputArgm[0];
                string model = inputArgm[1];
                string color = inputArgm[2];
                int horsePower = int.Parse(inputArgm[3]);

                if(typeOfVehicle == "car")
                {
                    Car car = new Car(model, color, horsePower);
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(model, color, horsePower);
                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                if(catalog.Cars.Any(x => x.model == input))
                {
                    PrintFromCarsCatalog(catalog, input);                   
                }

                if(catalog.Trucks.Any(x => x.model == input))
                {
                    PrintFromTrucksCatalog(catalog, input);                   
                }

                input = Console.ReadLine();
            }

            double averageCarsPower = CalculateAverageCarsPower(catalog);            

            if(averageCarsPower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            double averageTrucksPower = CalculateAverageTrucksPower(catalog);

            if(averageTrucksPower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }

        private static double CalculateAverageTrucksPower(Catalog catalog)
        {
            double totalTruckPower = 0;

            foreach (var truck in catalog.Trucks)
            {
                totalTruckPower += truck.power;
            }

            int countOFTrucks = catalog.Trucks.Count();

            double averageTruckPower = totalTruckPower / countOFTrucks;

            return averageTruckPower;
        }

        private static double CalculateAverageCarsPower(Catalog catalog)
        {
            double totalCarsPower = 0;
            foreach (var car in catalog.Cars)
            {
                totalCarsPower += car.power;
            }

            int countOfCars = catalog.Cars.Count();
            double averageCarsPower = totalCarsPower / countOfCars;
            
            return averageCarsPower;            
        }

        private static void PrintFromTrucksCatalog(Catalog catalog, string input)
        {
            Console.WriteLine("Type: Truck");

            foreach (var truck in catalog.Trucks.Where(x => x.model == input))
            {
                Console.WriteLine($"Model: {truck.model}");
                Console.WriteLine($"Color: {truck.color}");
                Console.WriteLine($"Horsepower: {truck.power}");
            }
        }

        private static void PrintFromCarsCatalog(Catalog catalog, string input)
        {
            Console.WriteLine("Type: Car");

            foreach (Car car in catalog.Cars.Where(x => x.model == input))
            {
                Console.WriteLine($"Model: {car.model}");
                Console.WriteLine($"Color: {car.color}");
                Console.WriteLine($"Horsepower: {car.power}");
            }
        }
    }
}

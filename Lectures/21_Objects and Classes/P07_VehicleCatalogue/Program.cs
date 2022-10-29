using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        //Brand, Model, and Weight.

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        //Brand, Model, and Horse Power
        public string Brand { set; get; }
        public string Model { set; get; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Truck = new List<Truck>();
            Car = new List<Car>();
        }

        //Collections of Trucks and Cars.

        public List<Truck> Truck { get; set; }
        public List<Car> Car { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] inputArgm = input
                    .Split('/', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //{ type}/{ brand}/{ model}/{ horse power / weight}

                string type = inputArgm[0];
                string brand = inputArgm[1];
                string model = inputArgm[2];
                int horsePowerOrWeight = int.Parse(inputArgm[3]);

                if(type == "Car")
                {
                    Car car = new Car(brand, model, horsePowerOrWeight);
                    catalog.Car.Add(car);                  
                }
                else
                {
                    Truck truck = new Truck(brand, model, horsePowerOrWeight);
                    catalog.Truck.Add(truck);                    
                }

                input = Console.ReadLine();
            }

            var orderedTruckCatalog = catalog.Truck.OrderBy(x => x.Brand).ToList();
            var orderedCarCatalog = catalog.Car.OrderBy(x => x.Brand).ToList();

            if(orderedCarCatalog.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in orderedCarCatalog)
                {

                    string brand = car.Brand;
                    string model = car.Model;
                    int horsePower = car.HorsePower;

                    Console.WriteLine($"{brand}: {model} - {horsePower}hp");
                }
            }

            if(orderedTruckCatalog.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTruckCatalog)
                {
                    string brand = truck.Brand;
                    string model = truck.Model;
                    int weight = truck.Weight;

                    Console.WriteLine($"{brand}: {model} - {weight}kg");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main()
        {
            CarLot UsedCars = new CarLot("Luie's");
            
            Vehicle car1 = new Truck("1E102", "Ford", "F-150", 40000, 5);
            Vehicle car2 = new Car("10202", "Toyota", "Camry", 24000, "Sedan", 4);
            UsedCars.AddCar(car1);
            UsedCars.AddCar(car2);
            Vehicle car3 = new Truck("10101", "Toyota", "Tocoma", 45000, 6);
            Vehicle car4 = new Car("1E201", "Chevrolet", "Corvette", 65000, "Coupe", 2);
            UsedCars.AddCar(car3);
            UsedCars.AddCar(car4);
            UsedCars.PrintInventory();
            Console.WriteLine(" ");
        }
    }

    class CarLot
    {
        public string Name { get; private set; }

        public CarLot(string name)
        {
            Name = name;
        }

        public List<Vehicle> ListCars = new List<Vehicle>();

        public virtual void AddCar(Vehicle car1)
        {
            ListCars.Add(car1);
        }

        public virtual void PrintInventory()
        {
            Console.WriteLine("Car lot {0} has the following vehicles parked in it:", Name);
            foreach (Vehicle vehicle in ListCars)
            {
                Console.WriteLine(vehicle.VehicleDesc());
            }
        }
    }

    abstract class Vehicle
    {
        
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public Vehicle(string licenseNumber, string make, string model, int price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
        }

        public virtual string VehicleDesc()
        {
            string VehicleDesc = Make + " " + Model + " with license plate " + LicenseNumber + " that costs $" + Price + ".";
            return VehicleDesc;
        }
    }

    class Truck : Vehicle
    {
        public int BedSize { get; set; }

        public Truck(string licenseNumber, string make, string model, int price, int bedSize) : base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            BedSize = bedSize;
        }

        public override string VehicleDesc()
        {
            string VehicleDesc = Make + " " + Model + " with license plate " + LicenseNumber + " that costs $" + Price + " and has a " + BedSize + "' bed.";
            return VehicleDesc;
        }
    }

    class Car : Vehicle
    {
        
        public string Type { get; set; }
        public int Doors { get; set; }

        public Car(string licenseNumber, string make, string model, int price, string type, int doors) : base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            Type = type;
            Doors = doors;
        }
        public override string VehicleDesc()
        {
            string VehicleDesc = Make + " " + Model + " is a " + Doors + " door " + Type + " with license plate " + LicenseNumber + " that costs $" + Price + ".";
            return VehicleDesc;
        }
    }
}
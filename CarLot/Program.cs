using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main()
        {
            CarLot C1 = new CarLot("C-1");
            CarLot R7 = new CarLot("R-7");
            Vehicle car1 = new Truck("G1ZBG", "Ford", "F-150", 40000, 5);
            Vehicle car2 = new Car("HG63TV", "Hyundai", "Elantra", 24000, "Sedan", 4);
            C1.AddCar(car1);
            C1.AddCar(car2);
            Vehicle car3 = new Truck("LBK-3399", "Toyota", "Tundra", 45000, 6);
            Vehicle car4 = new Car("NCM-5453", "Chevrolet", "Corvette", 65000, "Coupe", 2);
            R7.AddCar(car3);
            R7.AddCar(car4);
            C1.PrintInventory();
            Console.WriteLine(" ");
            R7.PrintInventory();
            Console.Read();
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
            Console.WriteLine("Parking lot {0} has the following vehicles parked in it:", Name);
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
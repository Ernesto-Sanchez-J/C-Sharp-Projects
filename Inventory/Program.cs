﻿using System;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat SpeedBoat = new Boat("Speed Boat");
            House BeachHouse = new House("Beach House");
            Car SportsCar = new Car("Sports Car");
            List<Irentable> Rentals = new List<Irentable>() { SpeedBoat, BeachHouse, SportsCar };
            foreach(Irentable rental in Rentals)
            {
                Console.WriteLine(rental.GetDescription());
            }
            Console.Read();
        }
    public interface Irentable
        {
            decimal GetDailyRate();
            string GetDescription();
        }
    }
    public class Boat 
    {
        public string Description { get; set; }
        public decimal HourlyRate { get; set; }
        public Boat(string description)
        {
            Description = description;
            HourlyRate = 50;
        }
        public decimal GetDailyRates()
        {
            decimal DailyRate = HourlyRate * 25;
            return DailyRate;
        }
        public string GetDescription()
        {
            return "The" + Description + " is a speed boat that costs $" + string.Format("{0:F2}", GetDailyRates()) + " per day.";
        }
    }
    class House
    {
        public string Description { get; set; }
        public decimal WeeklyRate { get; }
        public House(string description)
        {
            Description = description;
            WeeklyRate = 500;
        }
        public decimal GetDailyRates()
        {
            decimal DailyRate = WeeklyRate / 7;
            return DailyRate;
        }
        public string GetDescription()
        {
            return "The" + Description + " is a beach house that costs $" + string.Format("{0:F2}", GetDailyRates()) + " per day.";
        }
    }
    class Car
    {
        public string Description { get; set; }
        public decimal WeeklyRate { get; }
        public Car(string description)
        {
            Description = description;
            Hourly_Rate = 25;
        }
        public decimal GetDailyRates()
        {
            decimal DailyRate = Hourly_Rate * 24;
            return DailyRate;
        }
        public string GetDescription()
        {
            return "The" + Description + " is a sports car that costs $" + string.Format("{0:F2}", GetDailyRates()) + " per day.";
        }
    }
}

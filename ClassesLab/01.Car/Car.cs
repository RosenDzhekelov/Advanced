﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public Engine Engine  { get; set; }
        public Tire[] Tires { get; set; }
        public Car(string make ,string model , int year, double fuelQuantity , double fuelConsumption
            ,Engine engine , Tire[] tires)
            :this( make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }
        public Car(string make , string model , int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string  make , string model , int year , double fuelQuantity ,double fuelConsumption)
            :this(make , model , year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            
        }
        public void Drive(double distance)
        {
            if (distance * FuelConsumption - FuelQuantity > 0)
            {
                FuelQuantity -= distance * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {Make}\nModel: {Model}\nYear {Year}\nFuel: {FuelQuantity}");
            return sb.ToString();
            
        }
    }
}

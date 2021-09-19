using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public  class Car
    {
        //        string Model
        //double FuelAmount
        //double FuelConsumptionPerKilometer
        //double Travelled distance
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public Car(string model , double fuelAmount , double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            Distance = 0;
        }


        public void TravelCheck(double distance)
        {
            if(FuelConsumption*distance<=FuelAmount)
            {
                Distance += distance;
                FuelAmount -= FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}

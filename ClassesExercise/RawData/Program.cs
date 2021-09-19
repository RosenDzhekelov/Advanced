using System;
using System.Collections.Generic;
using System.Linq;

namespace  DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(int.Parse(input[1]),int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4].ToLower());
                Tire[] tireSet = new Tire[4];
                int pressureIndex = 5;
                int ageIndex = 6;
                for (int j = 0; j < 4; j++)
                {
                    Tire tire = new Tire(double.Parse(input[pressureIndex]), int.Parse(input[ageIndex]));
                    tireSet[j] = tire;
                    pressureIndex += 2;
                    ageIndex += 2;
                }
                Car car = new Car(input[0], engine, cargo, tireSet);
                cars.Add(car);
            }

            string cargoType = Console.ReadLine().ToLower();
            if(cargoType=="fragile")
            {
              cars =  cars.Where(x => x.Tire.Any(t=> t.Pressure<1) && x.Cargo.Type == cargoType).ToList();
            }
            else if(cargoType=="flammable")
            {
                cars = cars.Where(x => x.Engine.Power > 250 && x.Cargo.Type == cargoType).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

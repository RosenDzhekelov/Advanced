using System;
using System.Collections.Generic;

namespace DefiningClasses
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
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            
            while(true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(tokens[0].ToLower()=="end")
                {
                    break;
                }
                int index = cars.FindIndex(x => x.Model == tokens[1]);
                cars[index].TravelCheck(double.Parse(tokens[2]));
               
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}

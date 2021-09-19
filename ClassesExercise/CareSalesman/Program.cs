using System;
using System.Collections.Generic;
using System.Linq;

namespace CareSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //"{model} {power} {displacement} {efficiency}"
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] engineModels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine();
                engine.Model = engineModels[0];
                engine.Power = int.Parse(engineModels[1]);
                if (engineModels.Length == 3)
                {
                    if(int.TryParse(engineModels[2],out int result))
                    {
                        engine.Displacement = result.ToString();
                    }
                    else
                    {
                       engine.Efficiency= engineModels[2];
                    } 
                }
                else if(engineModels.Length==4)
                {
                    engine.Displacement = engineModels[2];
                    engine.Efficiency = engineModels[3];
                }
                engines.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] carModels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                car.Model = carModels[0];
                car.Engine =  engines.Find(x => x.Model == carModels[1]);
                if (carModels.Length == 3)
                {
                    if (int.TryParse(carModels[2], out int result))
                    {
                       car.Weight = result.ToString();
                    }
                    else
                    {
                        car.Color = carModels[2];
                    }
                }
                else if (carModels.Length == 4)
                {
                    car.Weight = carModels[2];
                    car.Color= carModels[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}

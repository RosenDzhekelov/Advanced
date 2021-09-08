using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            string inputTires = Console.ReadLine();
            while(inputTires!="No more tires")
            {
                
                List<string> tokens = inputTires.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Tire[] tireSet = new Tire[4];
                for (int i = 0; i < 4; i++)
                {
                    Tire tire = new Tire(int.Parse(tokens[0]), double.Parse(tokens[1]));
                    tireSet[i] = tire;
                    tokens.RemoveAt(0);
                    tokens.RemoveAt(0);

                }


                tires.Add(tireSet);
                inputTires = Console.ReadLine();
            }
            string inputEngine = Console.ReadLine();
            List<Engine> engines = new List<Engine>();
            while(inputEngine!= "Engines done")
            {
                string[] tokens = inputEngine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(int.Parse(tokens[0]),double.Parse(tokens[1]));
                engines.Add(engine);
                inputEngine = Console.ReadLine();
            }

            string inputCars = Console.ReadLine();
            List<Car> cars = new List<Car>();
            while(inputCars!= "Show special")
            
            {
                string[] tokens = inputCars.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] tireSet = tires[int.Parse(tokens[6])];
                Car car = new Car(tokens[0], tokens[1], int.Parse(tokens[2]), double.Parse(tokens[3])
                    , double.Parse(tokens[4]), engines[int.Parse(tokens[5])], tireSet);
                cars.Add(car);
                inputCars = Console.ReadLine();
            }

           cars =  cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(s => s.Pressure) >= 9 &&
            x.Tires.Sum(s => s.Pressure) <= 10).ToList();

            foreach (Car car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI()); 
            }
        }
    }
}

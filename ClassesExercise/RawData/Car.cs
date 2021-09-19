using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}" +
        //    " {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} " +
        //    "{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
        //The speed, power, weight and tire age are integers and tire pressure is a double. 
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; } 

        public Car(string model, Engine engine, Cargo cargo, Tire[] tire )
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tire = tire;
            
        }
      

}
}

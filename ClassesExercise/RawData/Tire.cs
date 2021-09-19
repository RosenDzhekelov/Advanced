using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Tire
    {

        //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}" +
        //    " {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} " +
        //    "{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
        //The speed, power, weight and tire age are integers and tire pressure is a double. 
        public int Age { get; set; }
        public double Pressure { get; set; }

        public Tire(double pressure, int age )
        {
            Age = age;
            Pressure = pressure;
        }
    }
}

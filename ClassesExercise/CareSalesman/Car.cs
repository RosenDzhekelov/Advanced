
using System;
using System.Collections.Generic;
using System.Text;

namespace CareSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; } = "n/a";
        public string Color { get; set; } = "n/a";
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");
            sb.AppendLine($"    Displacement: {Engine.Displacement}");
            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            sb.AppendLine($"  Weight: {Weight}");
            sb.AppendLine($"  Color: {Color}");
            return sb.ToString();
        }


    }
}

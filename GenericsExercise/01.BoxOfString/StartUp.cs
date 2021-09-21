using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box = new Box<double>();
            double value =double.Parse(Console.ReadLine());
            Console.WriteLine(box.GreaterThan(list, value));

        }
    }
}

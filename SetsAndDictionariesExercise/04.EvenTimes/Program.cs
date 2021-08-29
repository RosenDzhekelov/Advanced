using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<double, int>();
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number]++;
                }
            }
            foreach (var number in numbers.Where(x=> x.Value%2==0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}

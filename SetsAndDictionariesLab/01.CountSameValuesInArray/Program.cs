using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if(!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 1;
                }
                else
                {
                    dict[input[i]]++;
                }
            }

            foreach (var number in dict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}

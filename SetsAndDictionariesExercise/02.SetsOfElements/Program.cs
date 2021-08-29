using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < n+m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(i<n)
                {
                    firstSet.Add(num);
                }
                else
                {
                    secondSet.Add(num);
                }
            }
            foreach (var number in firstSet)
            {
                if(secondSet.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}

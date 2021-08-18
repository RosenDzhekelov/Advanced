using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var tankCap = new Queue<int>();
            var gasCap = new Queue<int>();
            int tank = 0;
            int gas = 0;
            int pump = 1;
            int bestIndex = 0;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();
                tankCap.Enqueue(input[0]);
                gasCap.Enqueue(input[1]);
                if (pump > 1)
                {
                    tank += tankCap.Dequeue();
                    gas = gasCap.Dequeue();
                    if (tank >= gas)
                    {
                        tank -= gas;
                        pump++;
                    }
                    else
                    {
                        pump = 1;
                        continue;
                    }
                }
                if (pump==1)
                {
                    tank = tankCap.Dequeue();
                    gas = gasCap.Dequeue();
                    if (tank >= gas)
                    {
                        tank -= gas;
                        pump++;
                        bestIndex = i;
                    }
                }
              
            }

            Console.WriteLine(bestIndex);
        }
    }
}

using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            while(input.ToUpper()!="END")
            {
                if(input.ToUpper()=="GREEN")
                {
                    int passing = Math.Min(n, cars.Count);
                    for (int i = 0; i < passing; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                   
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

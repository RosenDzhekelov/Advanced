using System;
using System.Collections.Generic;

namespace _06.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var clients = new Queue<string>();
            while(input!="End")
            {
                if(input!="Paid")
                {
                    clients.Enqueue(input);
                }
                else if(input=="Paid")
                {
                    while(clients.Count>0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{clients.Count} people remaining.");

        }
    }
}

using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            while(kids.Count>1)
            {
                for (int i = 0; i < n; i++)
                {
                   string kid = kids.Dequeue();
                    if(i+1<n)
                    {
                        kids.Enqueue(kid);
                    }
                    else
                    {
                        Console.WriteLine($"Removed {kid}");
                    }
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int magazineSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int bulletCount = 0;
            
            while(bullets.Count>0 && locks.Count > 0)
            {
                bool isLoaded = true;
                for (int i = 0; i < magazineSize; i++)
                {
                    if (i == magazineSize - 1)
                    {
                        isLoaded = false;
                    }
                    if (bullets.Count==0 || locks.Count==0)
                    {
                        break;
                    }
                    int checker = bullets.Pop();
                    bulletCount++;
                    if (checker > locks.Peek())
                    {
                        Console.WriteLine("Ping!");
                    }
                    else
                    {
                        locks.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                }
                if (bullets.Count > 0 && !isLoaded)
                {
                    Console.WriteLine("Reloading!");
                }
               
            }
            if(locks.Count>0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = value - bulletCount * bulletCost;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}

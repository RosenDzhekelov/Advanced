using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            var que = new Queue<int>(orders);
            Console.WriteLine(que.Max());
            while (true)
            {
                if (que.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                else if (que.Peek() <= foodQuantity)
                {
                    foodQuantity -= que.Dequeue();
                }

                else if (foodQuantity < que.Peek())
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", que)}");
                    break;
                }
            }

        }
    }
}

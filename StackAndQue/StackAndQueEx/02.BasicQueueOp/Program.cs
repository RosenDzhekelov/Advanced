using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var que = new Queue<int>();
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Min(input[0],numbers.Length); i++)
            {
                que.Enqueue(numbers[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                if(que.Count>0)
                {
                    que.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if(que.Count==0)
            {
                Console.WriteLine(0);
            }
            else if(que.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(que.Min());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
           int[] numbers = Console.ReadLine()
                  .Split().Select(int.Parse).ToArray();
            for (int i = 0; i < input[0]; i++)
            {
                if (i < numbers.Length)
                {
                    stack.Push(numbers[i]);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < input[1]; i++)
            {
                if(stack.Count>0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }
            if(stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}

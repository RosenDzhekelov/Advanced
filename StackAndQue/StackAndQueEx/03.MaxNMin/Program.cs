using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxNMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();
                if(input[0]==1)
                {
                    stack.Push(input[1]);
                }
                else if(input[0]==2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if(input[0]==3&&stack.Count>0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (input[0] == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}

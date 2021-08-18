using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int counter = 1;
            int rack = 0;
            while(stack.Count>0)
            {
                if(stack.Peek()+rack<=capacity)
                {
                    rack += stack.Pop();
                }
                else
                {
                    rack = 0;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

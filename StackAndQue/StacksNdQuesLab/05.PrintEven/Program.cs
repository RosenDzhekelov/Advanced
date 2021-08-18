using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(nums);
            for (int i = 0; i <nums.Length; i++)
            {
                int checker = numbers.Peek();
                numbers.Dequeue();
                if (checker%2==0)
                {
                    numbers.Enqueue(checker);
                }
            }
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}

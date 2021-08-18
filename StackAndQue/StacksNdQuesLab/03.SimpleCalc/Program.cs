using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split().Reverse().ToArray();
            var numbers = new Stack<string>(input);
            while(numbers.Count>1)
            {
                int firstNum = int.Parse(numbers.Pop());
                string op = numbers.Pop();
                int secondNum = int.Parse(numbers.Pop());
                if(op=="+")
                {
                    numbers.Push((firstNum + secondNum).ToString());
                }
                else if(op=="-")
                {
                    numbers.Push((firstNum - secondNum).ToString());
                }

            }
            Console.WriteLine(numbers.Pop());
        }
    }
}

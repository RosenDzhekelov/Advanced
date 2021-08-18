using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numberStack = new Stack<int>(input);
            string command = Console.ReadLine().ToUpper();
            while(command!="END")
            {
                string[] tokens = command.Split();
                if(tokens[0]=="ADD")
                {
                    numberStack.Push(int.Parse(tokens[1]));
                    numberStack.Push(int.Parse(tokens[2]));
                }
                else if(tokens[0]=="REMOVE")
                {
                    int count = int.Parse(tokens[1]);
                    if (count <= numberStack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (numberStack.Count > 0)
                            {
                                numberStack.Pop();
                            }
                        }
                    }
                }
                command = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"Sum: {numberStack.Sum()}");
        }
    }
}

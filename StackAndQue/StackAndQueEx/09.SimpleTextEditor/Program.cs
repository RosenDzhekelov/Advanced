using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            var stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    stack.Push(text);
                    text += command[1];

                }
                else if (command[0] == "2")
                {
                    stack.Push(text);
                    int count = int.Parse(command[1]);
                    int index = text.Length - count;
                    if (count < 0)
                    {
                        text = text.Remove(0);
                    }
                    else
                    {
                        text = text.Remove(index, count);
                    }

                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]) - 1;
                    Console.WriteLine(text[index]);

                }
                else if (command[0] == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}

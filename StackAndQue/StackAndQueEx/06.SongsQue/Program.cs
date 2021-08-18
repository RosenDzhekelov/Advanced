using System;
using System.Collections.Generic;

namespace _06.SongsQue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            var que = new Queue<string>(songs);
            while(true)
            {
                if(que.Count==0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                string[] input = Console.ReadLine().Split();
                if(input[0]=="Play")
                {
                    que.Dequeue();
                }
                else if(input[0]=="Add")
                {
                    string song = string.Empty;
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (i + 1 < input.Length)
                        {
                            song += input[i] + " ";
                        }
                        else
                        {
                            song += input[i];
                        }
                    }
                    if (que.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        que.Enqueue(song);
                    }
                }
                else if(input[0]=="Show")
                {
                    Console.WriteLine(String.Join(", ",que));
                }
            }
        }
    }
}

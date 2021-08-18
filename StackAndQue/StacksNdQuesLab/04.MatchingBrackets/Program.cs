using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var bracketIndex = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]=='(')
                {
                    bracketIndex.Push(i);
                }
                else if(input[i]==')')
                {
                    int endIndex = i;
                    int startIndex = bracketIndex.Pop();
                    Console.WriteLine(input.Substring(startIndex,endIndex-startIndex+1));
                }
            }
        }
    }
}

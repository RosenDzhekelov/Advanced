using System;
using System.Collections.Generic;

namespace _08.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var que = new Queue<char>(input);
            bool isBalanced = false;
            
            while(que.Count>0)
            {
               char currentBracket = que.Dequeue();
                isBalanced = false;
                int count = que.Count;
                bool isMatched = false;
                if(currentBracket=='{')
                {
                    for (int i = 0; i < count; i++)
                    {
                        char matchBracket = que.Dequeue();
                        if (matchBracket=='}' && i%2==0&& !isMatched)
                        {
                            isBalanced = true;
                            isMatched = true;
                        }
                        else
                        {
                            que.Enqueue(matchBracket);
                        }
                    }
                }
                else if(currentBracket=='[')
                {
                    for (int i = 0; i < count; i++)
                    {
                        char matchBracket = que.Dequeue();
                        if (matchBracket == ']' && i % 2 == 0 && !isMatched)
                        {
                            isBalanced = true;
                            isMatched = true;
                        }
                        else
                        {
                            que.Enqueue(matchBracket);
                        }
                    }
                }
                else if (currentBracket == '(')
                {
                    for (int i = 0; i < count; i++)
                    {
                        char matchBracket = que.Dequeue();
                        if (matchBracket == ')' && i % 2 ==0 &&!isMatched)
                        {
                            isBalanced = true;
                            isMatched = true;
                        }
                        else
                        {
                            que.Enqueue(matchBracket);
                        }
                    }
                }
                if (isBalanced==false)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
            if(isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}

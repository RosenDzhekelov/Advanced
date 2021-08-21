using System;
using System.Linq;

namespace _06.JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = ReadArray();
            }
            string input = Console.ReadLine().ToUpper();
            while(input!="END")
            {
                string[] splitted = input.Split();
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);
                if(row<0 || col<0 || row>=rows ||col>=jagged.GetLength(0))
                {
                    Console.WriteLine("Invalid coordinates");
                     input = Console.ReadLine().ToUpper();
                    continue;
                }
                if (splitted[0]=="ADD")
                {
                    jagged[row][col] += value;
                }
                else if(splitted[0]=="SUBTRACT")
                {
                    jagged[row][col] -= value;
                }

                input = Console.ReadLine().ToUpper();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(" ",item));
            }
            
        }

        private static int[] ReadArray()
        {
            return Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
        }
    }
}

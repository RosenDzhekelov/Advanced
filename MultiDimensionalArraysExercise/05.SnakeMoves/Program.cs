using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            int index = 0;
            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int rows = 0; rows < sizes[0]; rows++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    if (rows % 2 == 0)
                    {
                        matrix[rows, col] = input[index];
                        if (col != sizes[1] - 1)
                        {
                            index++;
                            if (index >= input.Length)
                            {
                                index = 0;
                            }
                        }
                        else
                        {
                            index--;
                        }
                    }
                    else
                    {
                        if (index < 0)
                        {
                            index = input.Length - 1;
                        }
                        matrix[rows, col] = input[index];
                        index--;
                       

                    }
                    Console.Write(matrix[rows, col]);
                }
                Console.WriteLine();
            }

        }
    }
}

using System;
using System.Linq;

namespace _05.SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] input = ReadArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < sizes[0]-1; row++)
            {
                for (int col = 0; col < sizes[1]-1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1]
                                    + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow,maxCol+1]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1,maxCol+1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadArray()
        {
            return Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
        }
    }
}

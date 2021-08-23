using System;
using System.Linq;

namespace _03.MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int a = 3;

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] input = ReadArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int maxSum = int.MinValue;

            int bestRow = 0;
            int bestCol = 0;
            for (int i = 0; i <= sizes[0]-a; i++)
            {
                int currentRow = 0;
                int currentCol = 0;
                int counter = 0;
                int currentSum = 0;
                for (int j = 0; j <= sizes[1]-a; j++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        for (int l = 0; l < a; l++)
                        {
                            if (counter == 0)
                            {
                                currentCol = j;
                                currentRow = i;
                            }
                            currentSum += matrix[i + k, l+j];
                        }
                        counter++;
                    }
                    counter = 0;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = currentRow;
                        bestCol = currentCol;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = bestRow; i < a+bestRow; i++)
            {
                for (int j = bestCol; j < a+bestCol; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
           
        }

        public static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}

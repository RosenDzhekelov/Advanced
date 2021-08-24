using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }
            int[] coordinates = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < coordinates.Length - 1; i += 2)
            {
                int currentCol = coordinates[i + 1];
                int currentRow = coordinates[i];
                bool isBoom = false;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == currentRow && col == currentCol && matrix[row,col]>0)
                        {
                            if (col - 1 >= 0 && matrix[row, col] > 0)
                            {
                                matrix[row, col - 1] -= matrix[row, col];

                            }
                            if (row - 1 >= 0)
                            {
                                if (matrix[row - 1, col] > 0)
                                {
                                    matrix[row - 1, col] -= matrix[row, col];
                                }
                                if (col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                                {
                                    matrix[row - 1, col - 1] -= matrix[row, col];
                                }
                                if (col + 1 < n && matrix[row - 1, col + 1] > 0)
                                {
                                    matrix[row - 1, col + 1] -= matrix[row, col];
                                }
                            }
                            if (col + 1 < n && matrix[row, col + 1] > 0)
                            {
                                matrix[row, col + 1] -= matrix[row, col];
                            }
                            if (row + 1 < n)
                            {
                                if (matrix[row + 1, col] > 0)
                                {
                                    matrix[row + 1, col] -= matrix[row, col];
                                }
                                if (col + 1 < n && matrix[row + 1, col + 1] > 0)
                                {
                                    matrix[row + 1, col + 1] -= matrix[row, col];
                                }
                                if (col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                                {
                                    matrix[row + 1, col - 1] -= matrix[row, col];
                                }
                            }
                            matrix[row, col] = 0;
                            isBoom = true;
                            break;
                        }
                    }
                    if (isBoom)
                    {
                        break;
                    }
                }
            }

            int count = 0;
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


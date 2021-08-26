using System;
using System.Linq;

namespace _10.RadioactiveVampireMutant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine().ToUpper();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        currentCol = col;
                        currentRow = row;
                        matrix[row, col] = '.';
                    }
                }
            }
            string command = Console.ReadLine().ToUpper();

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'U')
                {
                    if (currentRow - 1 < 0)
                    {
                        BunnySpread(matrix,sizes);
                        PrintMatrix(matrix);
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        break;
                    }
                    else
                    {
                        currentRow--;
                        BunnySpread(matrix,sizes);
                        PrintMatrix(matrix);
                        if (matrix[currentRow, currentCol] == 'B')
                        {
                            PrintMatrix(matrix);
                            Console.WriteLine($"dead: {currentRow} {currentCol}");
                            break;
                        }
                    }
                }
                else if (command[i] == 'D')
                {
                    if (currentRow + 1 >=sizes[0])
                    {
                        BunnySpread(matrix, sizes);
                        PrintMatrix(matrix);
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        break;
                    }
                    else
                    {
                        currentRow++;
                        BunnySpread(matrix, sizes);
                        if (matrix[currentRow, currentCol] == 'B')
                        {
                            PrintMatrix(matrix);
                            Console.WriteLine($"dead: {currentRow} {currentCol}");
                            break;
                        }
                    }
                }
                else if (command[i] == 'R')
                {
                    if (currentCol + 1 >= sizes[1])
                    {
                        BunnySpread(matrix, sizes);
                        PrintMatrix(matrix);
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        break;
                    }
                    else
                    {
                        currentCol++;
                        BunnySpread(matrix, sizes);
                        if (matrix[currentRow, currentCol] == 'B')
                        {
                            PrintMatrix(matrix);
                            Console.WriteLine($"dead: {currentRow} {currentCol}");
                            break  ;
                        }
                    }
                }
                else if (command[i] == 'L')
                {
                    if (currentCol - 1 <0)
                    {
                        BunnySpread(matrix, sizes);
                        PrintMatrix(matrix);
                        Console.WriteLine($"won: {currentRow} {currentCol}");
                        break;
                    }
                    else
                    {
                        currentCol--;
                        BunnySpread(matrix, sizes); 
                        PrintMatrix(matrix);
                        if (matrix[currentRow, currentCol] == 'B')
                        {
                            PrintMatrix(matrix);
                            Console.WriteLine($"dead: {currentRow} {currentCol}");
                            break;
                        }
                    }
                }
            }


        }

        private static void BunnySpread(char[,] matrix, int[] sizes)
        {
            for (int row = 0; row < sizes[0]; row++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row - 1 >= 0)
                        {
                            matrix[row - 1, col] = '*';
                        }
                        if (row + 1 < sizes[0])
                        {
                            matrix[row + 1, col] = '*';
                        }
                        if (col - 1 >= 0)
                        {
                            matrix[row, col - 1] = '*';
                        }
                        if (col + 1 < sizes[1])
                        {
                            matrix[row, col + 1] = '*';
                        }
                    }
                }
            }
            for (int row = 0; row <sizes[0]; row++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    if(matrix[row,col]=='*')
                    {
                        matrix[row, col] = 'B';
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

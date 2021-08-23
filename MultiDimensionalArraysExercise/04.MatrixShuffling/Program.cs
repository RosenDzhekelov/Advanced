using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            for (int row = 0; row < sizes[0]; row++)
            {
                string[] rows = Console.ReadLine().Split();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0].ToUpper() == "END")
                {
                    break;
                }
                else if (input[0].ToLower() == "swap" && input.Length==5)
                {
                    int firstRow = int.Parse(input[1]);
                    int firstCol = int.Parse(input[2]);
                    int secondRow = int.Parse(input[3]);
                    int secondCol = int.Parse(input[4]);
                    bool isInvalid = firstRow < 0 || firstRow >= sizes[0] || secondRow < 0 || secondRow >= sizes[0]
                        || firstCol < 0 || firstCol >= sizes[1] || secondCol < 0 || secondCol >= sizes[1];
                 
                    if (isInvalid)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string temp = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = temp;
                    for (int row = 0; row < sizes[0]; row++)
                    {
                        for (int col = 0; col < sizes[1]; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }


    }
}

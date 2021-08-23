using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            char[,] matrix = new char[sizes[0], sizes[1]];
            for (int row = 0; row < sizes[0]; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < sizes[0]-1; row++)
            {
                for (int col = 0; col < sizes[1]-1; col++)
                {
                    if(matrix[row,col]==matrix[row,col+1]
                        &&matrix[row,col]==matrix[row+1,col]
                        && matrix[row + 1, col]==matrix[row+1,col+1])
                    {

                        counter++;
                    }
                }
            }
                Console.WriteLine(counter);

        }

       public static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}

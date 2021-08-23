using System;
using System.Linq;

namespace _01.DiagonalDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int primarySum = 0;
            int secondarySum = 0;
            int coloumn = n;
            for (int i = 0; i < n; i++)
            {
                primarySum += matrix[i, i];
                coloumn--;
                secondarySum += matrix[i, coloumn];
            }
            Console.WriteLine(Math.Abs(secondarySum-primarySum));
        }
    }
}

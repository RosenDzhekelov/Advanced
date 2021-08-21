using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isContained = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col]==symbol)
                    {
                        isContained = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            if(!isContained)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            
        }
    }
}

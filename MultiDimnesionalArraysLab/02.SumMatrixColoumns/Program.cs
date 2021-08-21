using System;
using System.Linq;

namespace _02.SumMatrixColoumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = ReadArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
          
        private static int[] ReadArray()
        {
            return Console.ReadLine()
               .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
        }
    }
}

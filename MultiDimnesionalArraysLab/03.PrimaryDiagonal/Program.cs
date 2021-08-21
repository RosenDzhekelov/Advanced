﻿using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}

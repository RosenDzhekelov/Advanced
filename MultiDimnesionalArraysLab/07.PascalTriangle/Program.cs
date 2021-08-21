using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] jagged = new long[rows][];
            for (int i = 0; i < rows; i++)
            {
                long[] row = new long[i + 1];
                row[0] = 1;
                row[i] = 1;
                for (int j = 1; j < i; j++)
                {
                    row[j] = jagged[i - 1][j - 1]+jagged[i-1][j];
                }
                jagged[i] = row;
                Console.WriteLine(String.Join(" ",jagged[i]));
            }
            
        }
    }
}

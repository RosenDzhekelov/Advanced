using System;
using System.Linq;

namespace _07.KnightsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string rows = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            bool isValid = false;
            int removedKnights = 0;
            while (!isValid)
            {
                int currentCount = 0;
                int bestCounter = 0;
                int bestRow = 0;
                int bestCol = 0;
                bool isContained = false;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                       
                        if (matrix[row, col] == 'K')
                        {
                            if ( row - 2 >= 0  )
                            {
                                if (col - 1 >= 0)
                                {
                                    if (matrix[row - 2, col - 1] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                                if (col + 1 < n)
                                {
                                    if (matrix[row - 2, col + 1] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                            }
                            if ( row - 1 >= 0 )
                            {
                                if (col - 2 >= 0)
                                {
                                    if (matrix[row - 1, col - 2] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                                if (col + 2 < n)
                                {
                                    if (matrix[row - 1, col + 2] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                            }
                            if ( row + 2 < n )
                            {
                                if (col + 1 < n)
                                {
                                    if (matrix[row + 2, col + 1] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                                if (col - 1 >= 0)

                                {
                                    if (matrix[row + 2, col - 1] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                            }
                            if ( row + 1 < n )
                            {
                                if (col + 2 < n)
                                {
                                    if (matrix[row + 1, col + 2] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                                if (col - 2 >= 0)
                                {
                                    if (matrix[row + 1, col - 2] == 'K')
                                    {
                                        currentCount++;
                                    }
                                }
                            }
                            if(currentCount>bestCounter)
                            {
                                bestCol = col;
                                bestRow = row;
                                bestCounter = currentCount;
                                isContained = true;
                            }
                            currentCount = 0;
                        }
                    }
                }
                if(!isContained)
                {
                    isValid = true;
                }
                else
                {
                    matrix[bestRow, bestCol] = '0';
                    removedKnights++;
                }
            }
            Console.WriteLine(removedKnights);
        }


    }
}

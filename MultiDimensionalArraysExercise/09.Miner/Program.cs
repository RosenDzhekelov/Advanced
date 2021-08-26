using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int coalTotal = 0;
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < n; row++)
            {
                char[] rows = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = rows[col];
                    if (rows[col] == 'c')
                    {
                        coalTotal++;
                    }
                    if (rows[col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            int coalCount = 0;
            //⦁	* – a regular position on the field.
            //⦁	e – the end of the route.
            //⦁	c - coal
            //⦁	s - the place where the miner starts
            bool isOver = false;
            for (int i = 0; i < command.Length; i++)
            {
                command[i] = command[i].ToLower();
                if (command[i] == "up" &&currentRow - 1 >= 0)
                {
                    currentRow--;
                   isOver = GameEnds(field, currentRow, currentCol);
                    if (field[currentRow, currentCol] == 'c')
                    {
                        coalCount++;
                        field[currentRow, currentCol] = '*';
                        coalTotal--;
                    }
                }
                else if (command[i] == "down" && currentRow + 1 < n)
                {
                    currentRow++;
                    isOver = GameEnds(field, currentRow, currentCol);
                    if (field[currentRow, currentCol] == 'c')
                    {
                        coalCount++;
                        field[currentRow, currentCol] = '*';
                        coalTotal--;
                    }
                }
                else if (command[i] == "right"&&currentCol+1<n)
                {
                    currentCol++;
                    isOver = GameEnds(field, currentRow, currentCol);
                    if (field[currentRow, currentCol] == 'c')
                    {
                        coalCount++;
                        field[currentRow, currentCol] = '*';
                        coalTotal--;
                    }
                }
                else if (command[i] == "left"&&currentCol-1>=0)
                {
                    currentCol--;
                    isOver = GameEnds(field, currentRow, currentCol);
                    if (field[currentRow, currentCol] == 'c')
                    {
                        coalCount++;
                        field[currentRow, currentCol] = '*';
                        coalTotal--;
                    }
                }
                if(coalTotal==0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
                if(isOver)
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
            }
            Console.WriteLine($"{coalTotal} coals left. ({currentRow}, {currentCol})");

        }


        private static bool GameEnds(char[,] field, int currentRow, int currentCol)
        {
            if (field[currentRow, currentCol] == 'e')
            {
                return true;
            }
            return false;
        }
    }
}

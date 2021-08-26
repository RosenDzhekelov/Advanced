using System;
using System.Linq;
using System.Numerics;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[] rows = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jagged[row] = rows;
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                        jagged[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i <jagged[row].Length; i++)
                    {  
                            jagged[row][i] /= 2; 
                    }
                    for (int i = 0; i < jagged[row+1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);
                if (row >= 0 && row < n && col >= 0 && col < jagged[row].Length)
                {
                    if (tokens[0].ToLower() == "add")
                    {
                        //Add {row} {column} {value}"
                        //add {value} to the element at the given indexes, if they are valid

                        jagged[row][col] += value;
                    }
                    else if (tokens[0].ToLower() == "subtract")
                    {
                        //Subtract {row} {column} {value}" -
                        //subtract {value} from the element at the given indexes, if they are valid
                        jagged[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var arr in jagged)
            {
                Console.WriteLine(String.Join(" ",arr));
            }
        }

    
    }
}

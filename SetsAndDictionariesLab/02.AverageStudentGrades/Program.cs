using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(!students.ContainsKey(input[0]))
                {
                    students.Add(input[0], new List<decimal>());
                }
                students[input[0]].Add(decimal.Parse(input[1]));
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x=> x.ToString("F2")))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}

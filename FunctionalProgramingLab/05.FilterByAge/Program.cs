using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }
            string cond = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if(cond=="younger")
            {
               people = people.Where(p => p.Age < age).ToList();
            }
            else if(cond=="older")
            {
               people =  people.Where(p => p.Age >= age).ToList();
            }
            string[] format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var person in people)
            {
                if(format.Length==2)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if(format[0]=="name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else if(format[0]=="age")
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
        }
    }

    class Person
        {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }
}

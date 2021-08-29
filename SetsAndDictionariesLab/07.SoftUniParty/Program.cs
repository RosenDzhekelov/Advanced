using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipPeople = new HashSet<string>();
            var regularPeople = new HashSet<string>();
            string input = Console.ReadLine();
            bool isStarted = false;
            while (input?.ToUpper() != "END")
            {
                if (input?.ToUpper() == "PARTY")
                {
                    isStarted = true;
                }
                if (!isStarted)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipPeople.Add(input);
                    }
                    else
                    {
                        regularPeople.Add(input);
                    }
                }
                else
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipPeople.Remove(input);
                    }
                    else
                    {
                        regularPeople.Remove(input);
                    }
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine(vipPeople.Count+regularPeople.Count);
            foreach (var person in vipPeople)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regularPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}

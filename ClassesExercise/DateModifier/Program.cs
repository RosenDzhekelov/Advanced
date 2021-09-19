using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier date = new DateModifier(firstDate, secondDate);
            date.DifferenceInDays();
        }
    }
}

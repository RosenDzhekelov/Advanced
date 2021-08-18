using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CupsNBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedLiters = 0;
            bool isFilled = true;
            int currentCup = 0;
            while(bottles.Count>0 && cups.Count >0)
            {
                if (isFilled)
                {
                     currentCup = cups.Peek();
                }
                int currentBottle = bottles.Pop();
                if(currentCup<=currentBottle)
                {
                    isFilled = true;
                    cups.Dequeue();
                    wastedLiters += currentBottle - currentCup;
                }
                else
                {
                    isFilled = false;
                    currentCup -= currentBottle;
                }
            }
            if(cups.Count ==0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ",bottles)}");
            }
            else if(bottles.Count==0)
            {
                Console.WriteLine($"Cups: {String.Join(" ",cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            
        }
    }
}

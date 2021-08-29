using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parkingLot = new HashSet<string>();

            while(input?.ToUpper()!="END")
            {
                string[] splitter = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if(splitter[0]=="IN")
                {
                    parkingLot.Add(splitter[1]);
                }
                else
                {
                    parkingLot.Remove(splitter[1]);
                }


                input = Console.ReadLine();
            }
            if(parkingLot.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var carNumber in parkingLot)
            {
                Console.WriteLine(carNumber);
            }
        }
    }
}

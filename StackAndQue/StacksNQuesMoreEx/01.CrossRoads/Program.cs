using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace _03._Heroes_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            var carQue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            bool isSafe = true;
            while(input!="END")
            {
                if(input!="green")
                {
                    carQue.Enqueue(input);
                }
                else
                {
                    int timeToEnter = greenLight;
                    while(timeToEnter>0 && carQue.Count>0)
                    {
                        string carName = carQue.Dequeue();
                        if(carName.Length<=timeToEnter)
                        {
                            timeToEnter -= carName.Length;
                            counter++;
                        }
                        else
                        {
                            if (timeToEnter + freeWindow >= carName.Length)
                            {
                                counter++;
                                timeToEnter = 0;
                            }
                            else
                            {
                                int index = timeToEnter + freeWindow;
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{carName} was hit at {carName[index]}.");
                                isSafe = false;
                                break;
                            }
                        }
                    }
                    if(greenLight <=0 && carQue.Count>0)
                    {
                        carQue.Clear();
                    }
                    
                }
                if(!isSafe)
                {
                    break;
                }
                
                 input = Console.ReadLine();
            }
            if(isSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}
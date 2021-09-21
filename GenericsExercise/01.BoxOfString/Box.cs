using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.BoxOfString
{
   public class Box<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Box()
        {
            
        }
       
        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }

        public void Swap(int firstIndex, int secondIndex, List<T> elements)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;

            foreach (var value in elements)
            {
                Console.WriteLine($"{value.GetType()}: {value}");
            }
        }

        public int GreaterThan(List<T> list,T value)
        {
            int count = 0;
            Comparer<T> comparer = Comparer<T>.Default;
            foreach (var item in list)
            {
                if (comparer.Compare(item, value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

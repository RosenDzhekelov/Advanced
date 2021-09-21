using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Tuple
{
    public class Item3<T>
    {
        public T Value { get; set; }

        public Item3(T value)
        {
            Value = value; 
        }
    }
}

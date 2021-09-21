using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Tuple
{
    public class Item1<T>
    {
        public T Value { get; set; }
        public Item1( T value)
        {
            Value = value;
        }
    }
}

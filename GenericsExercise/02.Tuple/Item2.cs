using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Tuple
{
    public class Item2<T>
    {
        public T Value { get; set; }

        public Item2(T value)
        {
            Value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Tuple
{
    public class Tuple<T,V,U>
    {
        public Item1<T> FirstItem { get; set; }
        public Item2<V> SecondItem { get; set; }
        public Item3<U> ThirdItem { get; set; }

        public Tuple(Item1<T> item1 , Item2<V> item2 , Item3<U> item3)
        {
            FirstItem = item1;
            SecondItem = item2;
            ThirdItem = item3;
        }

    }
}

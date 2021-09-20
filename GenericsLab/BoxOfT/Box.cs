using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly Stack<T> elements;
        public int Count
        {
            get
            {
                return elements.Count;
            }
        }
        public Box()
        {
            elements = new Stack<T>();
        }
        public void Add(T element)
        {
            elements.Push(element);
        }
        public T Remove()
        {
           return elements.Pop();
        }
    }
}

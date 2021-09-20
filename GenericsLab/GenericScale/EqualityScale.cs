using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
   public class EqualityScale<T> where T : IComparable
    {
        private readonly T right;
        private readonly T left;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }
}

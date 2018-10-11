using System;

namespace Generics
{
    // we've created a generic class

    /* five types of constraints. T should be this or that.So you can have T as whatever you want but
         within certain categories
            where T : IComparable
            where T : Product
            where T : class
            where T : struct
            where T : new()     <--- an object that has a default ctor
     */
    public class Utilities<T> where T : IComparable
    {
        public int WhichIsGreater(int a, int b)
        {
            return a > b ? a : b;
        }

        
        public T WhichIsGreater(T a, T b)
        {
            // constraint: unless we put IComparable above, the computer doesn't know what Ta or Tb are so can't
            // evaluate the greater than expression
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

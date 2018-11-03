using System;

namespace ReferenceTypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // VALUE TYPES
            var a = 10;
            // Acopy of a's value has been stored inside b. a and b are now completely independent and making a change
            // to one doesn't impact the other
            var b = a;
            b++;

            Console.WriteLine("a is {0} and b is {1}", a, b);

            // REF TYPES
            var array1 = new int[3] { 10, 55, 144 };
            var array2 = array1;
            array2[0] = 0; 
            // array1 and array2 both point to the same object in memory. So here if you change something in array2,
            // it also changes in array1. Opposite to the VALUE TYPES rule.

            // this will print 10, not 0.
            Console.WriteLine("The value of the item at index 0 in array1 is {0}. The value of the item at index 0" +
                              " in array2 is {1}", array1[0], array2[0]);
        }
    }
}

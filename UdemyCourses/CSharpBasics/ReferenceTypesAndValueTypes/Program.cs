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


            // VALUE TYPE
            var number = 1;
            Increment(number);

            // number is 1, because this first number is in the scope of the Main method. It's not affected by the
            // Increment method
            Console.WriteLine(number);

            // REF TYPE
            var youngPerson = new Person { Age = 29 };
            MakeOld(youngPerson);
            // youngPerson's age is now 39
            Console.WriteLine(youngPerson.Age);

          
        }

        // this int is coincidentally also named namber but it exists in a different location in memory. This
        // has nothing to do with number up there because the scope of THIS number is limited to the Increment method
        static void Increment(int number)
        {
            number += 10;
        }

        // the Person object passed in here is not going to be copied: its REFERENCE will be copied
        static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

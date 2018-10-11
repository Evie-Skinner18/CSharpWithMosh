using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /* ENCAPSULATION.
             * We can hide some information. The waitress doesn't go and tell the chef how to chop the
             * veg, chop the meat etc. Similarly, the chef doesnt tell the waitress how to clear the tables
             * or be all charming! These things ar outside their responsibility. Each class has only one job and
             * it does it perfectly. We don't want other classes to know about all the details! We hide the details
             * from certain classes: so we can define certain fields as PRIVATE and then give them PUBLIC getters
             * and setters to access them when we need them. 
             * */
           // Console.WriteLine();

            var evie = new Person();

            // set the birth date to a value
            evie.SetBirthdate(new DateTime(1993, 06, 23));
            // read the birth date
            Console.WriteLine(evie.GetBirthdate());
            Console.ReadKey();
        }
    }
}

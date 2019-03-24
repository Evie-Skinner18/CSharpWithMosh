using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // basic class without getters and setters
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            // format string with parameters that we will fill in this order
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string myString)
        {
            var person = new Person();
            person.Name = myString;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Using the istance method Introduce means we have to create an instance of the Person
             */ 
            var person = new Person();
            person.Name = "Evie";
            person.Introduce("Mosh");
            
            /* Using thr static method Parse. It's static because if it were an instance method, 
             * we'd have to creaate an instance of Person
            before calling the Parse method which returns a Person. Doesn't make sense to create 
            *a Person twice! so here we can call Parse on the class not the object
            */
          var nelleth = Person.Parse("Nelly");
            //Console.WriteLine(nelleth);    you will see this is the class Person

            //we get the same result
            nelleth.Introduce("Dr Who");
          Console.ReadKey();
        }
    }
}

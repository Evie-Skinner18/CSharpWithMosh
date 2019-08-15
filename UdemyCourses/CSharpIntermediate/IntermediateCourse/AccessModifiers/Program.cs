using System;

namespace AccessModifiers
{
    class Program
    {

        /* OOP PRINCIPLE: ENCAPSULATION
         * 
         * you declare certain fields as private and then use getters and setters as public
         * in order to grab them
         * 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var evie = new Person();

            // my bday is special so you can't access it right away. Have to use setter and getter
            evie.SetBirthday(DateTime.Parse("23/06/1993"));
            var bestBday = evie.GetBirthday();
        }
    }
}

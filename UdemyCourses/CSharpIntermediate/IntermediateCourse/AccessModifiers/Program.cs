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

            var evie = new Person(new DateTime(1993, 06, 23));

            // my bday is special so you can't access it right away. Have to use setter and getter
            //evie.SetBirthday(DateTime.Parse("23/06/1993"));
            //var bestBday = evie.GetBirthday();

            var matureAge = evie.Age;

            Console.WriteLine(matureAge);

            // objects are about behaviour. Technically yeah you can access the _birthday field outside the class
            // but it's still hiding because you have to do extra work to reveal _birthday

            // you can do the same thing with less code by using PROPERTIES! :->

        }
    }
}

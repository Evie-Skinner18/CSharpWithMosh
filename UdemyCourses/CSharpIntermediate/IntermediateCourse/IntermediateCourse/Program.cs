using System;

namespace IntermediateCourse
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //var firstPerson = new Person
            //{
            //    Name = "bitch"
            //};

            //firstPerson.Introduce("Evie");

            // parse method is static so you can make a person without having to instatiate a person
            var anotherPerson = Person.Parse("bitch");
            anotherPerson.Introduce("Evie");

            var manInTheQueue = new Customer(1, "Bob");

        }
    }
}

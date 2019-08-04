using System;
namespace IntermediateCourse
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public Person()
        {
        }

        public void Introduce(string greetersName)
        {
            Console.WriteLine("Hello {0}, I am {1}", greetersName, FirstName);
        }

        public static Person Parse(string word)
        {
            var anotherPerson = new Person
            {
                FirstName = word
            };

            return anotherPerson;
        }
    }
}

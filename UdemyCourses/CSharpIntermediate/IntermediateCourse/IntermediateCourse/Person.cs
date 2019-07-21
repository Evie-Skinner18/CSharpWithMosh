using System;
namespace IntermediateCourse
{
    public class Person
    {
        public string Name;

        public Person()
        {
        }

        public void Introduce(string greetersName)
        {
            Console.WriteLine("Hello {0}, I am {1}", greetersName, Name);
        }

        public static Person Parse(string word)
        {
            var anotherPerson = new Person
            {
                Name = word
            };

            return anotherPerson;
        }
    }
}

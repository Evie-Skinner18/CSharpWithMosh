using System;

namespace Properties
{
    public class Person
    {
        public DateTime Birthday { get; private set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        
        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }

        public int GetAge()
        {
            var timeSpan = DateTime.Today - Birthday;
            var years = timeSpan.Days / 365;
            return years;
        }
    }
}

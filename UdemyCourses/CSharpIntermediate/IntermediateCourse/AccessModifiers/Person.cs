using System;

namespace AccessModifiers
{
    public class Person
    {
        public Person(DateTime dateTime)
        {
            Birthday = Birthday;
        }

        // PROEPRTIES AUTO-IMPLEMENTED WAY: C# compiler internally creates a private field
        // and implements getter and setter for us
        // setter is now private so we use dependency injection in the ctor to pass in a bday upon instantiation
        public DateTime Birthday { get; private set; }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthday;
                var years = timespan.Days / 365;

                return years;
            }
        }


        //private DateTime _birthday;

        // we are using dependency injection with the setter
        //public void SetBirthday(DateTime birthday)
        //{
        //    _birthday = birthday;
        //}

        // the getter gets you  the birthdayso even if it's private you can grab it this way
        //public DateTime GetBirthday()
        //{
        //    return _birthday;
        //}


        // PROPERTIES long way
        //public DateTime Birthdate
        //{
        //    get { return _birthday; }
        //    set { _birthday = value; }
        //}
    }
}

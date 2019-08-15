using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthday { get; set; }

        // we are using dependency injection with the setter
        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        // the getter gets you  the birthdayso even if it's private you can grab it this way
        public DateTime GetBirthday()
        {
            return _birthday;
        }


    }
}

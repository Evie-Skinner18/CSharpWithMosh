using System;

namespace AccessModifiers
{
    partial class Program
    {
        public class Person
        {
            // if the name is private, you cannot access the name elsewjere: can't put john.Name
            private DateTime _birthdate;

            // setter method gives birthdate a value
            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }
            // getter method goes and reads that value
            public DateTime GetBirthdate()
            {
                return _birthdate;
            }

        
        }
    }
}

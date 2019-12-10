using System;

namespace CtorsAndInheritance
{
    // CTORS AND INHERITANCE
    public class Vehicle
    {
        private readonly string _registrationNo;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle being initialised...");
        //}

        public Vehicle(string registrationNo)
        {
            _registrationNo = registrationNo;
            Console.WriteLine($"Vehicle being initialised with reg {registrationNo}");
        }

    }
}

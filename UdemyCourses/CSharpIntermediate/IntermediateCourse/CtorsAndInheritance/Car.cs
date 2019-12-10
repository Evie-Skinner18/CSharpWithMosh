using System;

namespace CtorsAndInheritance
{
    // CTORS AND INHERITANCE
    public class Car : Vehicle
    {
        // the ctor of the base class is always called first
        public Car(string registrationNo)
            : base(registrationNo)
        {
            Console.WriteLine($"Car being initialised with reg {registrationNo}");
        }
    }
}

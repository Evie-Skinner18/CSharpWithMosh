using System;

namespace Enums
{
    // enum is new type so need to define at the namespace level
    public enum ShippingMethod
    {
        RegularAirMail,
        RegisteredAirMail,
        Express
    }

    class Program
    {
        static void Main(string[] args)
        {
            // an enum is an int that can have different values. Instead of declaring three different consts, we can
            // declare one enum that has three different versions.
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace Enums
{
    // enum is new type so need to define at the namespace level
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // an enum is an int that can have different values. Instead of declaring three different consts, we can
            // declare one enum that has three different versions.
            var method = ShippingMethod.Express;

            // want to see the actual value of the Express member so we do a typecast to int
            Console.WriteLine((int)method);

            var methodId = 3;
            // want to see which member's value matches to three so we do a typecast to ShippingMethod
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method);

            // convert a string to an enum in two different ways
            string methodName = "Express";
            var parsedShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(parsedShippingMethod);

            var myShippingMethod = Enum.Parse<ShippingMethod>(methodName);
        }
    }
}

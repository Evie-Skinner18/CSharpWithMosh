using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello customers!");

            // usethe ctor that assigns an ID
            var customer = new Customer(1);

            // add an order

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            // Orders is 2
            Console.WriteLine(customer.Orders.Count);

            customer.Promote();
            // if Orders property is NOT set to readonly, Orders is now 0
            // Promote has reset Orders
            Console.WriteLine(customer.Orders.Count);
        }
    }
}

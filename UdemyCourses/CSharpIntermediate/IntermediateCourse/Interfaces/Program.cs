using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm ready for your order!");

            var shippingCalculator = new ShippingCalculator();
            var orderProcessor = new OrderProcessor(shippingCalculator);
            var order = new Order()
            {
                Shipment = new Shipment()
                {
                    Cost = 12f,
                    ShippingDate = DateTime.Today.AddDays(3)
                },
                TotalPrice = 14f
            };

            orderProcessor.ProcessOrder(order);
        }
    }
}

using System;

namespace Interfaces.Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        // now we're not dependent on the ShippingCalculator concrete class but on an interface! Loose coupling
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void ProcessOrder(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order has already been shipped");

            order.Shipment = new Shipment()
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}

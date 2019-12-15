using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;


        public OrderProcessor(ShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void ProcessOrder(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order has already been shipped");
            }

            else
            {
                order.Shipment = new Shipment()
                {
                    Cost = _shippingCalculator.CalculateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(1)

                };
            }
        }
    }
}

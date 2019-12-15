namespace Interfaces
{
    public class ShippingCalculator : IShippingCalculator
    {
        
        public float CalculateShipping(Order order)
        {
            // give them 10% off
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0f;
        }
    }
}

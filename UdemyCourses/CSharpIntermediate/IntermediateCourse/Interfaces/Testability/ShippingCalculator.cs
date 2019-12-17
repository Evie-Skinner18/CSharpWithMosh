namespace Interfaces.Testability
{
    public class ShippingCalculator : IShippingCalculator
    {
        // ShippingCalculator IMPLEMENTS IShippingCalculator not inherits
        public float CalculateShipping(Order order)
        {
            // give them 10% off
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0f;
        }
    }
}

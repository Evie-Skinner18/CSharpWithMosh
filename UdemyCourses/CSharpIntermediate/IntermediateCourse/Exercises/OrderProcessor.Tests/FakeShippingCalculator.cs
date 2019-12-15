using Interfaces;

namespace OrderProcessorTests
{
    // make a fake implementation of IShippingCalculaotr
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }

    }



}
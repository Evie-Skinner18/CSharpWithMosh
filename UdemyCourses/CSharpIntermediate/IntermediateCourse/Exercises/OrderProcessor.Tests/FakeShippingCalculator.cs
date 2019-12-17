using Interfaces;

namespace OrderProcessorTests
{
    // make a fake implementation of IShippingCalculator. This IMPLEMENTS IShippingCalculator 
    //not inherits
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }

    }



}
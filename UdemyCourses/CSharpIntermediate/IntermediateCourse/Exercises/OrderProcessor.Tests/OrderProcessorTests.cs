using NUnit.Framework;
using Interfaces.Testability;
using System;

namespace OrderProcessorTests
{
    public class OrderProcessorTests
    {
        private OrderProcessor _orderProcessor;
        private IShippingCalculator _shippingCalculator;

        [SetUp]
        public void Setup()
        {
            _shippingCalculator = new FakeShippingCalculator();
            _orderProcessor = new OrderProcessor(_shippingCalculator);
        }

        // negative use case
        [Test]
        public void CannotProcessShippedOrder_ShouldReturnInvalidOperationException()
        {
            var order = new Order(){TotalPrice = 12f, IsShipped = true};

            Assert.That(order, Is.Not.Null);
            Assert.That(order.IsShipped, Is.True);
            // pretty sure that's an Nunit lambda expression
            Assert.Throws<InvalidOperationException>(() => _orderProcessor.ProcessOrder(order));
        }

        [Test]
        public void CanCalculateShipping_ShouldReturn1f()
        {
            var order = new Order() { TotalPrice = 100f, IsShipped = false };
            var fakeCalculatorsShippingCost = _shippingCalculator.CalculateShipping(order);

            Assert.That(fakeCalculatorsShippingCost, Is.Not.Null);
            Assert.That(order.IsShipped, Is.False);
            Assert.That(fakeCalculatorsShippingCost, Is.EqualTo(1f));
        }
    }
}
using NUnit.Framework;
using Interfaces;
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

        
        [Test]
        public void CannotProcessShippedOrder_ShouldReturnInvalidOperationException()
        {
            var order = new Order(){TotalPrice = 12f, IsShipped = true};
           //_orderProcessor.ProcessOrder(order);

            Assert.That(order, Is.Not.Null);
            // pretty sure that's an Nunit lambda expression
            Assert.Throws<InvalidOperationException>(() => _orderProcessor.ProcessOrder(order));
        }
    }
}
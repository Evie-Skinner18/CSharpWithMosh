using NUnit.Framework;
using Classes.Maths;

namespace CSharpBasics.UnitTests
{
    [TestFixture]
    public class MathsUnitTests
    {
        [Test]
        public void CanAddTwoAndTwo_ShouldReturn4()
        {
            // arrange
            var calculator = new Calculator();
            // act
            var result = calculator.Add(2, 2);
            // assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}

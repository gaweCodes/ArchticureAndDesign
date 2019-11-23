using NUnit.Framework;

namespace StrategyPattern.Tests
{
    public class StrategyTests
    {
        [Test]
        public void PercentageDiscount_Calculate_Returns90()
        {
            const decimal price = 100;
            const decimal expected = 90;
            var sut = new Sale(new PercentageDiscount());
            Assert.That(sut.GetTotal(price), Is.EqualTo(expected));
        }
    }
}
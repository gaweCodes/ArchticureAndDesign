using System;
using Moq;
using NUnit.Framework;

namespace StrategyPattern.Tests
{
    public class StrategyTests
    {
        [Test]
        public void PercentageDiscountStrategy_WhenPrice100and10Percent_Then90()
        {
            const decimal expectedResult = 90;
            // Arrange
            var percentageDiscount = new PercentageDiscount(10);

            // Act
            var result = new Sale(percentageDiscount,100).GetTotal();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }
        [Test]
        public void CompositeStrategy_WhenPrice100and10Percent_Then90()
        {
            const decimal expectedResult = 90;
            // Arrange
            var compositePricing = new CompositePricing();

            compositePricing.Add(new NullDiscount());
            compositePricing.Add(new PercentageDiscount(10));
            var performace = new PerformaceMessureDiscountCalculatorDecorator(compositePricing);

            // Act
            var result = new Sale(performace,100).GetTotal();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        public void NullDiscountStrategy_WhenPrice100andNullDiscount_Then100()
        {
            const decimal expectedResult = 100;
            // Arrange
            var nullDiscount = new NullDiscount();

            // Act
            var result = new Sale(nullDiscount,100).GetTotal();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        [TestCase("100", "100", "90")]
        [TestCase("100", "99", "99")]
        [TestCase("100", "101", "91")]
        public void AbsoluteDiscountOverThresholdStrategy(string threshold, string price, string expectedResult)
        {
            // Arrange
            var absoluteDiscountOverThreshold = new AbsoluteDiscountOverThreshold(decimal.Parse(threshold), 10);

            // Act
            var result = new Sale(absoluteDiscountOverThreshold,decimal.Parse(price)).GetTotal();

            // Assert
            Assert.That(decimal.Parse(expectedResult), Is.EqualTo(result));
        }

        [Test]
        public void DiscountPendingOnDayTimeStrategy_WhenBefore12_ThenSingleDiscount()
        {
            const decimal expectedResult = 90;
            // Arrange
            var timeSourceMock = new Mock<ITimeSource>();
            timeSourceMock.Setup(x => x.Now).Returns(new DateTime(2018, 1, 1, 11, 59, 59));

            var discountPendingOnDayTime = new DiscountPendingOnDayTime(timeSourceMock.Object, 10);

            // Act
            var result = new Sale(discountPendingOnDayTime,100).GetTotal();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        public void DiscountPendingOnDayTimeStrategy_WhenAfter12_ThenDoubleDiscount()
        {
            const decimal expectedResult = 80;
            // Arrange
            var timeSourceMock = new Mock<ITimeSource>();
            timeSourceMock.Setup(x => x.Now).Returns(new System.DateTime(2018, 1, 1, 12, 01, 00));

            var discountPendingOnDayTime = new DiscountPendingOnDayTime(timeSourceMock.Object, 10m);

            // Act
            var result = new Sale(discountPendingOnDayTime, 100).GetTotal();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
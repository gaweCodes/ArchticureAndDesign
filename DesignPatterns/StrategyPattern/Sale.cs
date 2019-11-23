using System;

namespace StrategyPattern
{
    public class Sale
    {
        private readonly IDiscountCalculator _discountCalculator;

        public Sale(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }

        public decimal GetTotal(decimal price) => _discountCalculator.CalculateDiscount(price);
    }
}

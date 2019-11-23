namespace StrategyPattern
{
    public class PercentageDiscount : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price / 100 * (100 - 10);
        }
    }
}

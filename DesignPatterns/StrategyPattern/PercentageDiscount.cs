namespace StrategyPattern
{
    public class PercentageDiscount : IDiscountCalculator
    {
        private readonly decimal _percentageDiscount;
        public PercentageDiscount(decimal percentageDiscount)
        {
            _percentageDiscount = percentageDiscount;
        }
        public decimal CalculateDiscount(Sale sale) => sale.Price / 100 * (100 - _percentageDiscount);
    }
}

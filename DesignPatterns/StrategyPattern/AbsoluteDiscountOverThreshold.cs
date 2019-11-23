namespace StrategyPattern
{
    public class AbsoluteDiscountOverThreshold : IDiscountCalculator
    {
        private readonly decimal _threshold;
        private readonly decimal _absoluteDiscount;
        public AbsoluteDiscountOverThreshold(decimal threshold, decimal absoluteDiscount)
        {
            _threshold = threshold;
            _absoluteDiscount = absoluteDiscount;
        }
        public decimal CalculateDiscount(Sale sale) => sale.Price >= _threshold ? sale.Price - _absoluteDiscount : sale.Price;
    }
}

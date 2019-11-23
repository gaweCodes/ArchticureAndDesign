namespace StrategyPattern
{
    public class DiscountPendingOnDayTime : IDiscountCalculator
    {
        private readonly ITimeSource _timeSource;
        private readonly decimal _percentageDiscount;
        public DiscountPendingOnDayTime(ITimeSource timeSource, decimal percentageDiscount)
        {
            _timeSource = timeSource;
            _percentageDiscount = percentageDiscount;
        }
        public decimal CalculateDiscount(Sale sale) => _timeSource.Now.Hour < 12
                ? sale.Price - sale.Price / 100m * _percentageDiscount
                : sale.Price - sale.Price / 100m * _percentageDiscount * 2;
    }
}

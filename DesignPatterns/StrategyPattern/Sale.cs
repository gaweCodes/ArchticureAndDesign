namespace StrategyPattern
{
    public class Sale
    {
        public decimal Price { get; }
        private readonly IDiscountCalculator _discountCalculator;

        public Sale(IDiscountCalculator discountCalculator, decimal price)
        {
            _discountCalculator = discountCalculator;
            Price = price;
        }
        public decimal GetTotal() => _discountCalculator.CalculateDiscount(this);
    }
}

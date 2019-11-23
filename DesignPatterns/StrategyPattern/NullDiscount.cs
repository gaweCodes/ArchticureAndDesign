namespace StrategyPattern
{
    public class NullDiscount : IDiscountCalculator
    {
        public decimal CalculateDiscount(Sale sale) => sale.Price;
    }
}

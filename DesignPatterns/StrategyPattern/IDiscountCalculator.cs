namespace StrategyPattern
{
    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Sale sale);
    }
}

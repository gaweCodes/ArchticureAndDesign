using System;
using System.Diagnostics;

namespace StrategyPattern
{
    public class PerformaceMessureDiscountCalculatorDecorator : IDiscountCalculator
    {
        private readonly IDiscountCalculator _discountCalculator;
        public PerformaceMessureDiscountCalculatorDecorator(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }
        public decimal CalculateDiscount(Sale sale)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {
                return _discountCalculator.CalculateDiscount(sale);
            }
            finally
            {
                stopWatch.Stop();
                Console.WriteLine($"Performance: {stopWatch.ElapsedMilliseconds} ms");
            }
        }
    }
}

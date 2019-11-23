using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class CompositePricing : IDiscountCalculator
    {
        private readonly List<IDiscountCalculator> _discountCalculators;

        public CompositePricing()
        {
            _discountCalculators = new List<IDiscountCalculator>();
        }
        public void Add(IDiscountCalculator pricingCalculator) => _discountCalculators.Add(pricingCalculator);
        public decimal CalculateDiscount(Sale sale) => _discountCalculators.Min(pc => pc.CalculateDiscount(sale));
    }
}

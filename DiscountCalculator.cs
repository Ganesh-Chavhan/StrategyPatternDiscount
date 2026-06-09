using System;
using System.Collections.Generic;
using System.Text;

// this is Context class that uses the strategy pattern to calculate discounts based on different strategies

namespace StrategyPatternDiscount
{
    public class DiscountCalculator
    {
        private IDiscountStrategy strategy;

        public void SetStrategy(IDiscountStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double GetFinalAmount(double amount)
        {
            double discount = strategy.CalculateDiscount(amount);
            return amount - discount;
        }
    }
}

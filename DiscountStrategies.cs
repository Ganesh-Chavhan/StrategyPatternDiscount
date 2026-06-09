using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDiscount
{
    public class RegularDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }
    }

    public class StudentDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.10;
        }
    }

    public class PremiumDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.20;
        }
    }
}

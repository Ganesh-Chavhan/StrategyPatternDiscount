using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDiscount
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
}

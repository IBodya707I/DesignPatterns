using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal class PricingEngine: IPricingEngine
    {
        private ITaxCalculator _taxCalculator;

        public PricingEngine(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            var tax = _taxCalculator.CalculateTax(basePrice);
            return basePrice + tax;
        }
    }
}

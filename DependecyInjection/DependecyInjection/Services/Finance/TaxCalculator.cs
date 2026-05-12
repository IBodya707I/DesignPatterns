using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal class TaxCalculator: ITaxCalculator    
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.20m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal interface ITaxCalculator
    {
        decimal CalculateTax(decimal amount);
    }
}

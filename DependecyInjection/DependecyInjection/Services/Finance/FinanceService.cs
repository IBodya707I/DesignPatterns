using DependecyInjection.Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal class FinanceService: IFinanceService
    {
        private IPricingEngine pricingEngine;
        private ICreditChecker creditChecker;
        public FinanceService(IPricingEngine pricingEngine, ICreditChecker creditChecker, ILogger logger)
        {
            this.pricingEngine = pricingEngine;
            this.creditChecker = creditChecker;
        }
        public void ProcessPayment(string customerName, decimal basePrice)
        {
            if (creditChecker.CheckCredit(customerName))
            {
                var finalPrice = pricingEngine.CalculatePrice(basePrice);
            }
        }
    }
}

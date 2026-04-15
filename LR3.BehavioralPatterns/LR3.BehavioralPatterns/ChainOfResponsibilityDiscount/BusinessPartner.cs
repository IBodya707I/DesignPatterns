using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ChainOfResponsibilityDiscount
{
    internal class BusinessPartner: DiscountHandler
    {
        public BusinessPartner() { }
        public override void ProcessRequest(double discountPercentage)
        {
            if (discountPercentage <= 10)
            {
                Console.WriteLine($"Business Partner approved a discount of {discountPercentage}% for wholesale.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"Business Partner cannot approve a discount of {discountPercentage}%. Forwarding to the next handler...");
                _nextHandler.ProcessRequest(discountPercentage);
            }
            else
            {
                Console.WriteLine($"Business Partner cannot approve a discount of {discountPercentage}%. No further handlers available.");
            }
        }
    }
}

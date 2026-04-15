using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ChainOfResponsibilityDiscount
{
    internal class Owner: DiscountHandler
    {
        public Owner() { }
        public override void ProcessRequest(double discountPercentage)
        {
            if (discountPercentage <= 15)
            {
                Console.WriteLine($"Owner approved a discount of {discountPercentage}%.");
            }
            else
            {
                Console.WriteLine($"Owner cannot approve a discount of {discountPercentage}%. No further handlers available.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ChainOfResponsibilityDiscount
{
    internal class Manager: DiscountHandler
    {
        public Manager() { }
        public override void ProcessRequest(double discountPercentage)
        {
            if (discountPercentage <= 5)
            {
                Console.WriteLine($"Manager approved a discount of {discountPercentage}%.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"Manager cannot approve a discount of {discountPercentage}%. Forwarding to the next handler...");
                _nextHandler.ProcessRequest(discountPercentage);
            }
            else
            {
                Console.WriteLine($"Manager cannot approve a discount of {discountPercentage}%. No further handlers available.");
            }
        }
    }
}

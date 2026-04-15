using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ChainOfResponsibilityDiscount
{
    internal abstract class DiscountHandler
    {
        protected DiscountHandler _nextHandler;
        public void SetNextHandler(DiscountHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        public abstract void ProcessRequest(double discountPercentage);
    }
}

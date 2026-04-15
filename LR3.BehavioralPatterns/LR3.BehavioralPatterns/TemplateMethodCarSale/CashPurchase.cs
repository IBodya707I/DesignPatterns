using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.TemplateMethodCarSale
{
    internal class CashPurchase: AutoSalesProcess
    {
        public CashPurchase() { }
        protected override void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment...");
        }
        protected override void SetupInsurance()
        {
            Console.WriteLine("Setting up base insurance...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.TemplateMethodCarSale
{
    internal class CreditPurchase: AutoSalesProcess
    {
        public CreditPurchase() { }
        protected override void ProcessPayment()
        {
            Console.WriteLine("Processing credit payment...");
        }
        protected override void SetupInsurance()
        {
            Console.WriteLine("Setting up comprehensive insurance(required for bank financing)...");
        }
    }
}

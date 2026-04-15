using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.TemplateMethodCarSale
{
    internal abstract class AutoSalesProcess
    {
        public void ProcessSale()
        {
            Console.WriteLine("Starting the car sales process...");
            SignContract();
            ProcessPayment();
            SetupInsurance();
            HangOverKeys();
            Console.WriteLine("Car sales process completed.");
        }
        private void SignContract()
        {
            Console.WriteLine("Signing the sales contract...");
        }
        private void HangOverKeys()
        {
            Console.WriteLine("Hanging over the car keys...");
        }
        protected abstract void ProcessPayment();
        protected abstract void SetupInsurance();
    }
}

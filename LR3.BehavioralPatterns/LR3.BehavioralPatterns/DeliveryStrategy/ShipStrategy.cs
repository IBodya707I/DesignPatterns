using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.DeliveryStrategy
{
    internal class ShipStrategy: IDeliveryStrategy
    {
        public ShipStrategy() { }
        public void CalculateShipping()
        {
            Console.WriteLine("Calculating shipping cost for Ship delivery...");
        }
    }
}

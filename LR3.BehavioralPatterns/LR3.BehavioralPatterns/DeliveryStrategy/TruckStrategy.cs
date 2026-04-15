using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.DeliveryStrategy
{
    internal class TruckStrategy: IDeliveryStrategy
    {
        public TruckStrategy() { }
        public void CalculateShipping()
        {
            Console.WriteLine("Calculating shipping for truck...");
        }
    }
}

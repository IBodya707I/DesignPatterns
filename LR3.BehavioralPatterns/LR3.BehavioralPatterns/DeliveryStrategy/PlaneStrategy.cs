using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.DeliveryStrategy
{
    internal class PlaneStrategy: IDeliveryStrategy
    {
        public PlaneStrategy() { }
        public void CalculateShipping()
        {
            Console.WriteLine("Calculating shipping cost for Plane delivery...");
        }
    }
}

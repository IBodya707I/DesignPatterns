using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.DeliveryStrategy
{
    internal class ShoppingCart
    {
        private IDeliveryStrategy _deliveryStrategy;
        public ShoppingCart() { }
        public void SetDeliveryStrategy(IDeliveryStrategy deliveryStrategy)
        {
            _deliveryStrategy = deliveryStrategy;
        }
        public void CalculateShipping()
        {
            if (_deliveryStrategy == null)
            {
                Console.WriteLine("Please select a delivery strategy.");
                return;
            }
            _deliveryStrategy.CalculateShipping();
        }
    }
}

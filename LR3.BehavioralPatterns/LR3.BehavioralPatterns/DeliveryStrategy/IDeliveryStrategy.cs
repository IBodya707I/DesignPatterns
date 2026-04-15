using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.DeliveryStrategy
{
    public interface IDeliveryStrategy
    {
        public void CalculateShipping();
    }
}

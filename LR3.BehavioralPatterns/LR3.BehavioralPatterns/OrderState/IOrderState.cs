using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.OrderState
{
    internal interface IOrderState
    {
        void Pay(OrderContext context);
        void Ship(OrderContext context);    
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.OrderState
{
    internal class ShippedOrderState: IOrderState
    {
        public ShippedOrderState() { }
        public void Pay(OrderContext context)
        {
            Console.WriteLine("Order is already shipped. Cannot pay.");
        }
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order is already shipped.");
        }
    }
}

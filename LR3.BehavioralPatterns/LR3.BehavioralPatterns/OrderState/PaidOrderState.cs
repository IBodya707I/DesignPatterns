using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.OrderState
{
    internal class PaidOrderState: IOrderState
    {
        public PaidOrderState() { }
        public void Pay(OrderContext context)
        {
            Console.WriteLine("Order is already paid.");
        }
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order is now shipped. Transitioning to ShippedOrderState.");
            context.orderState = new ShippedOrderState();
        }
    }
}

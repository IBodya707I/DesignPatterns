using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.OrderState
{
    internal class NewOrderState: IOrderState
    {
        public NewOrderState() { }
        public void Pay(OrderContext context)
        {
            Console.WriteLine("Order is now paid. Transitioning to PaidOrderState.");
            context.orderState = new PaidOrderState();
        }
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order cannot be shipped. It is not paid yet.");
        }
    }
}

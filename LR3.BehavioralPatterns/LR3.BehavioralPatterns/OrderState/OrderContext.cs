using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.OrderState
{
    internal class OrderContext
    {
        public IOrderState orderState { get; set; }
        public OrderContext()
        {
            orderState = new NewOrderState();
            Console.WriteLine("Order created");
        }
        public void Pay()
        {
            orderState.Pay(this);
        }

        public void Ship()
        {
            orderState.Ship(this);
        }
    }
}

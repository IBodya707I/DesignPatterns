using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ObserverPattern
{
    internal class VipCustomer: ICustomerObserver
    {
        public VipCustomer() { }
        public int Priority { get;} = 100;
        public void Update(string product)
        {
            Console.WriteLine($"VIP Customer notified about new product: {product}");
        }
    }
}

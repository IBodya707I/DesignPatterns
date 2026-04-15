using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ObserverPattern
{
    internal class RegularCustomer: ICustomerObserver
    {
        public RegularCustomer() { }
        public int Priority { get;} = 10;
        public void Update(string product)
        {
            Console.WriteLine($"Regular Customer notified about new product: {product}");
        }
    }
}

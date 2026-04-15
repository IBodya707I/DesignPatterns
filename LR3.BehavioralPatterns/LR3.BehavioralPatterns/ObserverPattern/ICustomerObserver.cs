using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ObserverPattern
{
    internal interface ICustomerObserver
    {
        int Priority { get; }
        void Update(string product);
    }
}

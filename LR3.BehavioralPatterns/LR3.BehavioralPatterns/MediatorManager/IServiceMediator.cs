using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal interface IServiceMediator
    {
        void Notify(object sender, string message);
    }
}

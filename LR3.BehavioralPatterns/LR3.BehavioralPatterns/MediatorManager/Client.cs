using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal class Client: Colleague
    {
        public Client(IServiceMediator mediator) : base(mediator)
        {
        }
        public void RequestRepair()
        {
            Console.WriteLine("Client: Requesting repair service...");
            _mediator.Notify(this, "RequestRepair");
        }
    }
}

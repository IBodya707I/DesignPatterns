using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal class Cashier: Colleague
    {
        public Cashier(IServiceMediator mediator) : base(mediator) { }
        public void ProcessPayment()
        {
            Console.WriteLine("Cashier: Processing payment.");
            _mediator.Notify(this, "PaymentProcessed");
        }
    }
}

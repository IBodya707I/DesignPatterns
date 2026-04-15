using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal class Mechanic: Colleague
    {
        public Mechanic(IServiceMediator mediator) : base(mediator)
        {
        }
        public void RepairCar()
        {
            Console.WriteLine("Mechanic is repairing the car.");
            _mediator.Notify(this, "CarRepaired");
        }
    }
}

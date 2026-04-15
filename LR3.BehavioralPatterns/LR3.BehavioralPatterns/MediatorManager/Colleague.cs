using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal abstract class Colleague
    {
        protected IServiceMediator _mediator;
        public Colleague(IServiceMediator mediator)
        {
            _mediator = mediator;
        }
    }
}

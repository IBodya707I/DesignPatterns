using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal class BodyElement: ICarElement
    {
        public double Weight = 500.0;
        public BodyElement() { }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

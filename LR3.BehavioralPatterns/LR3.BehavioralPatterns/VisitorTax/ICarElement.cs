using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal interface ICarElement
    {
        void Accept(IVisitor visitor);
    }
}

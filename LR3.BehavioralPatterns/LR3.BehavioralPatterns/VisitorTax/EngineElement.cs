using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal class EngineElement: ICarElement
    {
        public int HorsePower { get; set; } = 150;
        public EngineElement() { }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

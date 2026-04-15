using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal interface IVisitor
    {
        void Visit(EngineElement engine);
        void Visit(BodyElement body);
    }
}

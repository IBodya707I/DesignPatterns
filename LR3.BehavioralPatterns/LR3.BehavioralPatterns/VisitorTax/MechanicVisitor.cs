using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal class MechanicVisitor: IVisitor
    {
        public void Visit(EngineElement engine)
        {
            Console.WriteLine($"Inspecting engine with {engine.HorsePower} HP");
        }
        public void Visit(BodyElement body)
        {
            Console.WriteLine($"Inspecting body with weight {body.Weight}");
        }
    }
}

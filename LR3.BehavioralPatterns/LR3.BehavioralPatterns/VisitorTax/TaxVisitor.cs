using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.VisitorTax
{
    internal class TaxVisitor: IVisitor
    {
        public void Visit(EngineElement engine)
        {
            var tax = engine.HorsePower * 0.1;
            Console.WriteLine($"Calculating tax for engine: {tax}");
        }
        public void Visit(BodyElement body) 
        {
            var tax = body.Weight * 0.05;
            Console.WriteLine($"Calculating tax for body: {tax}");
        }
    }
}

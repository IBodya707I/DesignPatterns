using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.BridgeCar
{
    internal class Coupe: Vehicle
    {
        public Coupe(ITransmission transmission) : base(transmission) { }   
        public override void Drive()
        {
            Console.WriteLine("Coupe is driving. " + transmission.ShiftGears);
        }

    }
}

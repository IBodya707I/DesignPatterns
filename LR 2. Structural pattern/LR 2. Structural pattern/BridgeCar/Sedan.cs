using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.BridgeCar
{
    internal class Sedan: Vehicle
    {
        public Sedan(ITransmission transmission) : base(transmission) { }
        public override void Drive()
        {
            Console.WriteLine("Sedan is driving." + transmission.ShiftGears);
        }
    }
}

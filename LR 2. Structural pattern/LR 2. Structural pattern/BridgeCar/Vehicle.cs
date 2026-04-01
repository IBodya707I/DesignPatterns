using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.BridgeCar
{
    internal abstract class Vehicle
    {
        protected ITransmission transmission;
        public Vehicle(ITransmission transmission)
        {
            this.transmission = transmission;
        }
        public abstract void Drive();
    }
}

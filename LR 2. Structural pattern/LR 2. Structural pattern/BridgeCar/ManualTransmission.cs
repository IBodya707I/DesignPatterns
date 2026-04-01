using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.BridgeCar
{
    internal class ManualTransmission: ITransmission
    {
        public string ShiftGears()
        {
            return "Manual transmission: Shifting gears manually.";
        }
    }
}

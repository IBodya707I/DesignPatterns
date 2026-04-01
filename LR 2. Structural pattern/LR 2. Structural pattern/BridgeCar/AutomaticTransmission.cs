using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.BridgeCar
{
    internal class AutomaticTransmission: ITransmission
    {
        public string ShiftGears()
        {
            return "Automatic transmission: Shifting gears automatically.";
        }
    }
}

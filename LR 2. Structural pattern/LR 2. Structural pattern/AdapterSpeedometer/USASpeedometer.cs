using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.AdapterSpeedometer
{
    internal class USASpeedometer: ISpeedometer
    {
        private double Speed { get; set; }
        public USASpeedometer(double speed)
        {
            Speed = speed;
        }
        public double GetSpeed()
        {
            return Speed; 
        }
    }
}

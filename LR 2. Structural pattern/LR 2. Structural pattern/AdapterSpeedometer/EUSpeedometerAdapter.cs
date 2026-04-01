using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.AdapterSpeedometer
{
    internal class EUSpeedometerAdapter: ISpeedometer
    {
        private USASpeedometer _usaSpeedometer;
        public EUSpeedometerAdapter(USASpeedometer usaSpeedometer)
        {
            _usaSpeedometer = usaSpeedometer;
        }
        public double GetSpeed()
        {
            return _usaSpeedometer.GetSpeed() * 1.60934; 
        }
    }
}

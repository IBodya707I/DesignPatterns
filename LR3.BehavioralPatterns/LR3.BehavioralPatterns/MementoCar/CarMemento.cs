using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MementoCar
{
    internal class CarMemento
    {
        public string Color { get; private set; }
        public int WheelsRadius { get; private set; }
        public string Interior { get; private set; }
        public CarMemento(string color, int wheelsRadius, string interior)
        {
            Color = color;
            WheelsRadius = wheelsRadius;
            Interior = interior;
        }
    }
}

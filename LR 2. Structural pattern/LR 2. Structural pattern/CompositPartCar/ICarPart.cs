using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.CompositPartCar
{
    internal interface ICarPart
    {
        double GetPrice();
        void Display(int indent);
    }
}

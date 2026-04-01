using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FacadeAutoSalon
{
    internal class Warehouse
    {
        public double GetCarPrice(string model)
        {
            return Random.Shared.Next(20000, 50000);
        }
    }
}

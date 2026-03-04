using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.AbstractFactoryTypeEngine
{
    internal class FuelTank: IEnergySource
    {
        public string Description()
            {
                return "Fuel tank";
        }
    }
}

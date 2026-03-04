using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.AbstractFactoryTypeEngine
{
    internal class GasolineFactory: ITypeEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
        public IEnergySource CreateEnergySource()
        {
            return new FuelTank();
        }
    }
}

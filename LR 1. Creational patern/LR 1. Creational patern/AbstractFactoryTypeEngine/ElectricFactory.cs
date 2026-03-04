using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.AbstractFactoryTypeEngine
{
    internal class ElectricFactory: ITypeEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new ElecticEngine();
        }
        public IEnergySource CreateEnergySource()
        {
            return new Battery();
        }
    }
}

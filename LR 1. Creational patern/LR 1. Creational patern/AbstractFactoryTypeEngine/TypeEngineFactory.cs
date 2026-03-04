using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.AbstractFactoryTypeEngine
{
    internal class TypeEngineFactory
    {
        public static ITypeEngineFactory GetFactory(TypeEngine type)
        {
            switch (type)
            {
                case TypeEngine.Gasoline:
                    return new GasolineFactory();
                case TypeEngine.Electric:
                    return new ElectricFactory();
                default:
                    throw new ArgumentException("Invalid type of engine");
            }
        }
    }
}

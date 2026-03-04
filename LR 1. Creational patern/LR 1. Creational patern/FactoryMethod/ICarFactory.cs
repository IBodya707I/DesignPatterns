using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryMethod
{
    internal interface ICarFactory
    {
        public ICar CreateCar(CarType carType);
    }
}

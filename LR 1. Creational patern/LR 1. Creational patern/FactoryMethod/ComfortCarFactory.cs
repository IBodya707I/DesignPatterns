using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryMethod
{
    internal class ComfortCarFactory: ICarFactory
    {
        public ICar CreateCar(CarType carType)
        {
            switch(carType)
            {
                case CarType.Sedan:
                    return new ComfortSedan();
                case CarType.SUV:
                    return new ComfortSUV();
                default:
                    throw new ArgumentException("Invalid car type");
            }
        }
    }
}

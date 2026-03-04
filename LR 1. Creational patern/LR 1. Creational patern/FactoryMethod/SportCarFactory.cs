using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryMethod
{
    internal class SportCarFactory: ICarFactory
    {
        public ICar CreateCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Sedan:
                    return new SportSedan();
                case CarType.SUV:
                    return new SportSUV();
                default:
                    throw new ArgumentException("Invalid Car Type");

            }
        }
    }
}

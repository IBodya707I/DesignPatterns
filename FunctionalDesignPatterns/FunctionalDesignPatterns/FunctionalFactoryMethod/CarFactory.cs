using System;
using System.Collections.Generic;
using System.Text;
using FunctionalDesignPatterns.FunctionalFactoryMethod.Models;

namespace FunctionalDesignPatterns.FunctionalFactoryMethod
{
    internal static class CarFactory
    {
        public static readonly Dictionary<(CarClassType carClass, CarType carType), Func<ICar>> _factory = new()
        {
            [(CarClassType.Sport, CarType.Sedan)] = () => new SportSedan(),
            [(CarClassType.Sport, CarType.SUV)] = () => new SportSUV(),
            [(CarClassType.Comfort, CarType.Sedan)] = () => new ComfortSedan(),
            [(CarClassType.Comfort, CarType.SUV)] = () => new ComfortSUV()
        };
        public static ICar CreateCar(CarClassType carClass, CarType carType)
        {
            if (_factory.TryGetValue((carClass, carType), out var creator))
            {
                return creator();
            }
            throw new ArgumentException("Invalid car class or type");
        }
    }
}

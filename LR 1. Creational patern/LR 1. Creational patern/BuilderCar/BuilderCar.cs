using System;
using System.Collections.Generic;
using System.Text;
using LR_1._Creational_patern.AbstractFactoryTypeEngine;
namespace LR_1._Creational_patern.BuilderCarAutoSalon
{
    internal class BuilderCar
    {
        private Car car;
        public BuilderCar()
        {
            car = new Car();
        }
        public BuilderCar SetModel(string model)
        {
            car.Model = model;
            return this;
        }
        public BuilderCar SetColor(string color)
        {
            car.Color = color;
            return this;
        }
        public BuilderCar SetEngine(IEngine engine)
        {
            car.Engine = engine;
            return this;
        }
        public BuilderCar SetEnergySource(IEnergySource energySource)
        {
            car.EnergySource = energySource;
            return this;
        }
        public Car Build()
        {
            return car;
        }
    }
}

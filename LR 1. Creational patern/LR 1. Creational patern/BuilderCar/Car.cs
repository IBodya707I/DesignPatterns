using System;
using System.Collections.Generic;
using System.Text;
using LR_1._Creational_patern.AbstractFactoryTypeEngine;
namespace LR_1._Creational_patern.BuilderCarAutoSalon
{
    internal class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public IEngine Engine { get; set; }
        public IEnergySource EnergySource { get; set; }
        public Car() { }
        public override string ToString()
        {
            string engineDescription = Engine != null ? Engine.Description() : "No engine";
            string energySourceDescription = EnergySource != null ? EnergySource.Description() : "No energy source";
            return $"Car model: {Model}, Color: {Color}, Engine: {engineDescription}, Energy Source: {energySourceDescription}";
        }
    }
}

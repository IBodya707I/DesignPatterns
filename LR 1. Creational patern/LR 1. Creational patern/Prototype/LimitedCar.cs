using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.Prototype
{
    internal class LimitedCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public LimitedCar(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public LimitedCar Clone()
        {
            return new LimitedCar(Model, Color);
        }
        public bool Equals(LimitedCar other)
        {
            if (other == null)
                return false;
            return Model == other.Model && Color == other.Color;
        }
        public override string ToString()
        {
            return $"Limited Car model: {Model}, Color: {Color}";
        }
    }
}

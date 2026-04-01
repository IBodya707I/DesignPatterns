using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FlyWeightCar
{
    internal class SharedCar
    {
        public string Type { get; private set; }
        public string Color { get; private set; }
        public SharedCar(string type, string color)
        {
            Type = type;
            Color = color;
        }
        public string GetCarInfo()
        {
            return $"Car Type: {Type}, Color: {Color}";
        }
    }
}

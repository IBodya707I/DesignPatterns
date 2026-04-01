using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FlyWeightCar
{
    internal class SharedCarFactory
    {
        private Dictionary<string, SharedCar> cars = new Dictionary<string, SharedCar>();
        public SharedCar GetSharedCar(string type, string color)
        {
            string key = $"{type}_{color}";
            if (!cars.ContainsKey(key))
            {
                cars[key] = new SharedCar(type, color);
            }
            return cars[key];
        }
    }
}

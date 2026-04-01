using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.DecoratorCar
{
    internal class BaseCar: ICar
    {
        public BaseCar() { }
        public string GetDiscription()
        {
            return "Base Car";
        }
        public double GetPrice()
        {
            return 10000;
        }
    }
}

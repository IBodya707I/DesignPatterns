using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.DecoratorCar
{
    internal class SportExhaust: CarDecorator
    {
        public SportExhaust(ICar car) : base(car) { }
        public override string GetDiscription()
        {
            return base.GetDiscription() + ", Sport Exhaust";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 2000;
        }
    }
}

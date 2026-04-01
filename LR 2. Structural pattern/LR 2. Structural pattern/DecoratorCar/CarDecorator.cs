using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.DecoratorCar
{
    internal abstract class CarDecorator: ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual string GetDiscription()
        {
            return car.GetDiscription();
        }
        public virtual double GetPrice()
        {
            return car.GetPrice();
        }
    }
}

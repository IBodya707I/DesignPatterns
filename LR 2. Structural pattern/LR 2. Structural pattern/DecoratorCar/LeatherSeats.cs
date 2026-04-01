using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.DecoratorCar
{
    internal class LeatherSeats: CarDecorator
    {
        public LeatherSeats(ICar car) : base(car) { }
        public override string GetDiscription()
        {
            return base.GetDiscription() + ", Leather Seats";
        }
        public override double GetPrice()
        {
            return (base.GetPrice() + 1500);
        }
    }
}

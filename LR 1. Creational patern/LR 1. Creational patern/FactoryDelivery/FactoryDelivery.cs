using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryDeliveryPattern
{
    internal class FactoryDelivery
    {
        public static IDelivery CreateDelivery(DeliveryType type)
        {
            switch (type)
            {
                case DeliveryType.Plane:
                    return new Plane();
                case DeliveryType.Truck:
                    return new Truck();
                case DeliveryType.Ship:
                    return new Ship();
                default:
                    throw new ArgumentException("Invalid delivery type");
            }
        }
    }
}

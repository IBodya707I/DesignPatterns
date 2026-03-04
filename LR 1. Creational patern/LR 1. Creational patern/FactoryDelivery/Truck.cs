using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryDeliveryPattern
{
    internal class Truck: IDelivery
    {
        public Truck() { }
        public string Description()
        {
            return "Delivery by truck";
        }
    }
}

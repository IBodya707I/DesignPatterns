using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.FactoryDeliveryPattern
{
    internal class Plane: IDelivery
    {
        public Plane() { }
        public string Description()
        {
            return "Delivery by plane";
        }
    }
}

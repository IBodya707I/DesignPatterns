using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Sales
{
    internal interface IInventorySystem
    {
        bool CheckAvailability(string vin);
    }
}

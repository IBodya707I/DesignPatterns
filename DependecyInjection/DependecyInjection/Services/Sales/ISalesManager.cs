using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Sales
{
    internal interface ISalesManager
    {
        void ProcessSell(string customerName, string carModel, string vin, decimal price);
    }
}

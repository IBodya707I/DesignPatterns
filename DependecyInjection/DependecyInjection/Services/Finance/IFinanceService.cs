using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal interface IFinanceService
    {
        void ProcessPayment(string customerName, decimal amount);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DependecyInjection.Services.Sales;
namespace DependecyInjection
{
    internal class DealershipApp
    {
        private ISalesManager salesManager;
        public DealershipApp(ISalesManager salesManager)
        {
            this.salesManager = salesManager;
        }
        public void Run()
        {
            salesManager.ProcessSell("John Doe", "BMW", "1HGCM82633A004352", 25000m);


        }
    }
}

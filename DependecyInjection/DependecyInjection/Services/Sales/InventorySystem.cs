using DependecyInjection.Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Sales
{
    internal class InventorySystem: IInventorySystem
    {
        private ILogger logger;
        public InventorySystem(ILogger logger)
        {
            this.logger = logger;
        }
        public bool CheckAvailability(string vin)
        {
            logger.LogInfo($"Checking availability for VIN: {vin}");
            return true;
        }
    }
}

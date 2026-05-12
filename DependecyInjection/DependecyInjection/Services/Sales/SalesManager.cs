using DependecyInjection.Services.Core;
using DependecyInjection.Services.Documents;
using DependecyInjection.Services.Finance;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Sales
{
    internal class SalesManager: ISalesManager
    {
        private IFinanceService financeService;
        private IDocumentProcessor documentProcessor;
        private IInventorySystem inventorySystem;
        public SalesManager(IFinanceService financeService, IDocumentProcessor documentProcessor, IInventorySystem inventorySystem)
        {
            this.financeService = financeService;
            this.documentProcessor = documentProcessor;
            this.inventorySystem = inventorySystem;
        }
        public void ProcessSell(string customerName, string carModel, string vin, decimal price)
        {
            if (inventorySystem.CheckAvailability(vin))
            {
                financeService.ProcessPayment(customerName, price);
                documentProcessor.GenerateDocument(customerName, carModel);
                inventorySystem.CheckAvailability(carModel);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n=========================================================");
                Console.WriteLine("           Congratulations on your purchase. ");
                Console.WriteLine("=========================================================");
                Console.ResetColor();
            }
        }
    }
}

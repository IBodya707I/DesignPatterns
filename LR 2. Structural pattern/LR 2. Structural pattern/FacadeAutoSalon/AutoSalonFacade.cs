using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FacadeAutoSalon
{
    internal class AutoSalonFacade
    {
        public void SellCar(string clientName, string model)
        {
            Warehouse warehouse = new Warehouse();
            double price = warehouse.GetCarPrice(model);
            BankSystem bankSystem = new BankSystem();
            Registration registration = new Registration();
            if (bankSystem.Pay(clientName, price))
            {
                registration.RegisterCar(clientName, model);
                Console.WriteLine($"AutoSalonFacade: {clientName} successfully bought a {model} for {price}.");
            }
            else
            {
                Console.WriteLine($"AutoSalonFacade: Payment failed for {clientName}. Could not sell the {model}.");
            }
        }
    }
}

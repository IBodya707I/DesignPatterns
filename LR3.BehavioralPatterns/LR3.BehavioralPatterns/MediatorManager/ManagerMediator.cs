using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MediatorManager
{
    internal class ManagerMediator: IServiceMediator
    {
        public Client Client { get; set; }
        public Mechanic Mechanic { get; set; }
        public Cashier Cashier { get; set; }
        public ManagerMediator() { }
        public void Notify(object sender, string message)
        {
            if(message == "RequestRepair")
            {
                Console.WriteLine("Manager received repair request from client.");
                Mechanic.RepairCar();
            }
            else if(message == "CarRepaired")
            {
                Console.WriteLine("Manager received notification that repair is completed.");
                Cashier.ProcessPayment();
            }
            else if(message == "PaymentProcessed")
            {
                Console.WriteLine("Manager received notification that payment is processed. Service complete.");
            }   
        }
    }
}

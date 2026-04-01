using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FacadeAutoSalon
{
    internal class BankSystem
    {
        public bool Pay(string clientName, double amount)
        {
            Console.WriteLine($"BankSystem: Payment of {amount} for {clientName} processed successfully.");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FacadeAutoSalon
{
    internal class Registration
    {
        public void RegisterCar(string clientName, string model)
        {
            Console.WriteLine($"Registration: {clientName} registered for {model}.");
        }
    }
}

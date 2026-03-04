using System;
using System.Collections.Generic;
using System.Text;

namespace LR_1._Creational_patern.SingletonManager
{
    internal class Manager
    {
        private int SoldCars = 0;  
        private static Manager _instance;
        private Manager() { }
        public static Manager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Manager();
            }
            return _instance;
        }
        public void SellCar()
        {
            SoldCars++;
            Console.WriteLine($"Car sold! Total sold cars: {SoldCars}");
        }
    }
}

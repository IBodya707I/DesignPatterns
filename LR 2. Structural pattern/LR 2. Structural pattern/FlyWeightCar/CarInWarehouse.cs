using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.FlyWeightCar
{
    internal class CarInWarehouse
    {
        public string VIN { get; private set; }
        public SharedCar SharedCar { get; private set; }
        public CarInWarehouse(string vin, SharedCar sharedCar)
        {
            VIN = vin;
            SharedCar = sharedCar;
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine(SharedCar.GetCarInfo() + " VIN: " + VIN);
        }
    }
}

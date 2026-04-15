using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.IteratorWarehouse
{
    internal class CarCatalog
    {
        private List<Car> cars = new List<Car>();
        public CarCatalog() { }
        public void AddItem(Car car)
        {
            cars.Add(car); 
        }
        public ICarIterator GetIterator()
        {
            return new CarCatalogIterator(cars);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.IteratorWarehouse
{
    internal class CarCatalogIterator: ICarIterator
    {
        private List<Car> _cars;
        private int _position = 0;

        public CarCatalogIterator(List<Car> cars)
        {
            _cars = cars;
        }

        public bool HasNext()
        {
            return _position < _cars.Count;
        }

        public Car Next()
        {
            if (!HasNext())
            {
                Console.WriteLine("No more cars in the catalog.");
            }
            return _cars[_position++];
        }

        public Car CurrentItem()
        {
            return _cars[_position];
        }
    }
}

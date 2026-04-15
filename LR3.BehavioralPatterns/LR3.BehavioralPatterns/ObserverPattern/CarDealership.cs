using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.ObserverPattern
{
    internal class CarDealership
    {
        private List<ICustomerObserver> _observers = new List<ICustomerObserver>();
        public void RegisterObserver(ICustomerObserver observer)
        {
            _observers.Add(observer);
        }
        public void UnregisterObserver(ICustomerObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(string product)
        {
            var sortedObservers = _observers.OrderByDescending(o => o.Priority).ToList();
            foreach (var observer in sortedObservers)
            {
                observer.Update(product);
            }
        }
    }
}

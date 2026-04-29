using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalStrategy
{
    internal class ShoppingCart
    {
        private double weight;
        private Func<double, double> deliveryStrategy;
        public ShoppingCart(double weight, Func<double, double> deliveryStrategy)
        {
            this.weight = weight;
            this.deliveryStrategy = deliveryStrategy;
        }

        public double CalculateShipping()
        {
            return deliveryStrategy(weight);
        }
    }
}

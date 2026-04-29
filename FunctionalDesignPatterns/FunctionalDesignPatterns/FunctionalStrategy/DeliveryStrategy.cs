using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalStrategy
{
    internal static class DeliveryStrategy
    {
        public static readonly Func<double, double> Truck = weight => {
            Console.WriteLine("Calculating shipping for truck...");
            return weight * 1.5;
        };
        public static readonly Func<double, double> Plane = weight => {
            Console.WriteLine("Calculating shipping cost for Plane delivery...");
            return weight * 1.2;
        };
        public static readonly Func<double, double> Ship = weight => {
            Console.WriteLine("Calculating shipping cost for Ship delivery...");
            return weight * 0.8;
        };

    }
}

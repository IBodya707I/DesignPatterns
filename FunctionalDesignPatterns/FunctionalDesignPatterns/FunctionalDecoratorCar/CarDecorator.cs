using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalDecoratorCar
{
    internal static class CarDecorator
    {
        public static readonly Func<(string Descriptions, double Price)> BaseCar =
            () => ("Base car", 10000);
        public static Func<(string Descriptions, double Price)> WithLeatherSeats(Func<(string Descriptions, double Price)> Car) => 
            () => {
                var current = Car();
                return (current.Descriptions + " + leather seats", current.Price + 2000);
            };
        public static Func<(string Descriptions, double Price)> WithSportExhaust(Func<(string Descriptions, double Price)> Car) => 
            () => {
                var current = Car();
                return (current.Descriptions + " + sport exhaust", current.Price + 1500);
            };
        public static void PrintCarInfo(Func<(string Descriptions, double Price)> Car)
        {
            var current = Car();
            Console.WriteLine($"{current.Descriptions}: {current.Price}");
        }
    }
}

using FunctionalDesignPatterns.ExecutionAround;
using FunctionalDesignPatterns.FunctionalDecoratorCar;
using FunctionalDesignPatterns.FunctionalFactoryMethod;
using FunctionalDesignPatterns.FunctionalFactoryMethod.Models;
using FunctionalDesignPatterns.FunctionalStrategy;
namespace FunctionalDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functional Factory Method Pattern");
            var sportSedan = CarFactory.CreateCar(CarClassType.Sport, CarType.Sedan);
            Console.WriteLine(sportSedan.Description());
            var comfortSUV = CarFactory.CreateCar(CarClassType.Comfort, CarType.SUV);
            Console.WriteLine(comfortSUV.Description());

            Console.WriteLine("\nFunctional Strategy Pattern");
            var cart = new ShoppingCart(10, DeliveryStrategy.Truck);
            Console.WriteLine($"Shipping cost: {cart.CalculateShipping()}");
            var cart2 = new ShoppingCart(10, weight => {
                Console.WriteLine("Calculating shipping cost for custom delivery...");
                return weight * 2.0;
            });
            Console.WriteLine($"Shipping cost: {cart2.CalculateShipping()}");

            Console.WriteLine("\nFunctional Decorator Pattern");
            var car = CarDecorator.BaseCar;
            CarDecorator.PrintCarInfo(car);
            car = CarDecorator.WithLeatherSeats(car);
            CarDecorator.PrintCarInfo(car);
            car = CarDecorator.WithSportExhaust(car);
            CarDecorator.PrintCarInfo(car);

            Console.WriteLine("\nExecution Around");
            ExecutionWrapper.WrapWithLogging(() =>
            {
                var car = CarFactory.CreateCar(CarClassType.Comfort, CarType.Sedan);
                Console.WriteLine(car.Description());
            });
            ExecutionWrapper.WrapWithLogging(() =>
            {
                var cart = new ShoppingCart(10, DeliveryStrategy.Plane);
                Console.WriteLine($"Shipping cost: {cart.CalculateShipping()}");
            });
        }
    }
}

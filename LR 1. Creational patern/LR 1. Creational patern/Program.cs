using LR_1._Creational_patern.AbstractFactoryTypeEngine;
using LR_1._Creational_patern.Prototype;
using LR_1._Creational_patern.BuilderCarAutoSalon; 
using LR_1._Creational_patern.FactoryDeliveryPattern;
using LR_1._Creational_patern.FactoryMethod;
using LR_1._Creational_patern.SingletonManager;
namespace LR_1._Creational_patern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Pattern:");
            var ElictricCarFactory = TypeEngineFactory.GetFactory(TypeEngine.Electric);
            var electricEngine = ElictricCarFactory.CreateEngine();
            var Battery = ElictricCarFactory.CreateEnergySource();
            Console.WriteLine($"Created engine: {electricEngine.Description()}");
            Console.WriteLine($"Created energy source: {Battery.Description()}");
            var GasolineCarFactory = TypeEngineFactory.GetFactory(TypeEngine.Gasoline);
            var gasolineEngine = GasolineCarFactory.CreateEngine();
            var fuelTank = GasolineCarFactory.CreateEnergySource();
            Console.WriteLine($"Created engine: {gasolineEngine.Description()}");
            Console.WriteLine($"Created energy source: {fuelTank.Description()}");
            Console.WriteLine("Abstract Facroty end");
            Console.WriteLine();

            Console.WriteLine("Builder Pattern:");
            var Car = new BuilderCar()
                .SetModel("Model")
                .SetColor("Red")
                .SetEngine(electricEngine)
                .Build();
            Console.WriteLine(Car);
            Console.WriteLine("Builder end");
            Console.WriteLine();

            Console.WriteLine("Factory Pattern:");
            var PlaneDelivery = FactoryDelivery.CreateDelivery(DeliveryType.Plane);
            var CarDelivery = FactoryDelivery.CreateDelivery(DeliveryType.Truck);
            var ShipDelivery = FactoryDelivery.CreateDelivery(DeliveryType.Ship);
            Console.WriteLine($"Created delivery: {PlaneDelivery.Description()}");
            Console.WriteLine($"Created delivery: {CarDelivery.Description()}");
            Console.WriteLine($"Created delivery: {ShipDelivery.Description()}");
            Console.WriteLine("Factory end");
            Console.WriteLine();

            Console.WriteLine("Factory Method Pattern:");
            ICarFactory CarFactory = new SportCarFactory();
            var Car1 = CarFactory.CreateCar(CarType.Sedan);
            Console.WriteLine($"Car factory created {Car1.Description()}");
            Car1 = CarFactory.CreateCar(CarType.SUV);
            Console.WriteLine($"Car factory created {Car1.Description()}");
            CarFactory = new ComfortCarFactory();
            Car1 = CarFactory.CreateCar(CarType.Sedan);
            Console.WriteLine($"Car factory created {Car1.Description()}");
            Car1 = CarFactory.CreateCar(CarType.SUV);
            Console.WriteLine($"Car factory created {Car1.Description()}");
            Console.WriteLine("Factory Method end");
            Console.WriteLine();

            Console.WriteLine("Prototype Pattern:");
            LimitedCar originalCar = new LimitedCar("Model S", "Red");
            Console.WriteLine(originalCar.GetHashCode());
            var CloneCar = originalCar.Clone();
            Console.WriteLine(CloneCar.GetHashCode());
            Console.WriteLine(originalCar.Equals(CloneCar));
            Console.WriteLine("Prototype end");
            Console.WriteLine();

            Console.WriteLine("Singleton Pattern:");
            var manager = Manager.GetInstance();
            Console.WriteLine(manager.GetHashCode());
            var manager1 = Manager.GetInstance();
            Console.WriteLine(manager1.GetHashCode());
            Console.WriteLine("Singleton end");
        }
    }
}

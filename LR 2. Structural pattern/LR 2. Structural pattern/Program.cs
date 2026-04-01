namespace LR_2._Structural_pattern
{
    using System;
    using LR_2._Structural_pattern.AdapterSpeedometer;
    using LR_2._Structural_pattern.BridgeCar;
    using LR_2._Structural_pattern.CompositPartCar;
    using LR_2._Structural_pattern.DecoratorCar;
    using LR_2._Structural_pattern.FacadeAutoSalon;
    using LR_2._Structural_pattern.ProxyTestDrive;
    using LR_2._Structural_pattern.FlyWeightCar;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern:");
            var USASpeedometer = new USASpeedometer(70);
            var adapter = new EUSpeedometerAdapter(USASpeedometer);
            Console.WriteLine("Speed in mph: " + USASpeedometer.GetSpeed());
            Console.WriteLine("Speed in km/h: " + adapter.GetSpeed());

            Console.WriteLine("\nComposite Pattern:");
            ICarPart sparkPlug = new SinglePart("Spark Plug", 30);
            ICarPart piston = new SinglePart("Piston", 100);
            ICarPart door = new SinglePart("Door", 200);
            CompositPart engine = new CompositPart("Engine");
            engine.AddPart(sparkPlug);
            engine.AddPart(piston);
            engine.AddPart(sparkPlug);
            CompositPart car = new CompositPart("Car");
            car.AddPart(engine);
            car.AddPart(door);
            car.Display();
            Console.WriteLine("Total cost: " + car.GetPrice());

            Console.WriteLine("\nProxy Pattern:");
            var testDriveProxy1 = new TestDriveProxy("John", "Doe", 25, true);
            testDriveProxy1.TestDrive();

            Console.WriteLine("\nFlyweight Pattern: ");
            var sharedCarFactory = new SharedCarFactory();
            sharedCarFactory.GetSharedCar("Red", "Sedan");
            var carInWarehouse = new CarInWarehouse("djfh466k5jh4", sharedCarFactory.GetSharedCar("Red", "Sedan"));
            var carInWarehouse2 = new CarInWarehouse("djfh83jrth54", sharedCarFactory.GetSharedCar("Red", "Sedan"));
            carInWarehouse2.DisplayCarInfo();
            carInWarehouse.DisplayCarInfo();
            
            Console.WriteLine("\nFacade Pattern:");
            var autoSalonFacade = new AutoSalonFacade();
            autoSalonFacade.SellCar("Alice", "Sedan");

            Console.WriteLine("\nBridge Pattern:");
            ITransmission manualTransmission = new ManualTransmission();
            ITransmission automaticTransmission = new AutomaticTransmission();
            Vehicle sedanWithManual = new Sedan(manualTransmission);
            Vehicle coupeWithAutomatic = new Coupe(automaticTransmission);
            sedanWithManual.Drive();
            coupeWithAutomatic.Drive();

            Console.WriteLine("\nDecorator Pattern:");
            ICar car1 = new BaseCar();
            Console.WriteLine(car1.GetDiscription());
            Console.WriteLine(car1.GetPrice());
            car1 = new LeatherSeats(car1);
            Console.WriteLine(car1.GetDiscription());
            Console.WriteLine(car1.GetPrice());
            car1 = new SportExhaust(car1);
            Console.WriteLine(car1.GetDiscription());
            Console.WriteLine(car1.GetPrice());

        }
    }
}

using LR3.BehavioralPatterns.ChainOfResponsibilityDiscount;
using LR3.BehavioralPatterns.Command;
using LR3.BehavioralPatterns.DeliveryStrategy;
using LR3.BehavioralPatterns.IteratorWarehouse;
using LR3.BehavioralPatterns.MediatorManager;
using LR3.BehavioralPatterns.MementoCar;
using LR3.BehavioralPatterns.ObserverPattern;
using LR3.BehavioralPatterns.OrderState;
using LR3.BehavioralPatterns.TemplateMethodCarSale;
using LR3.BehavioralPatterns.VisitorTax;
namespace LR3.BehavioralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template method pattern:");
            var cashPurchase = new CashPurchase();
            var creditPurchase = new CreditPurchase();

            cashPurchase.ProcessSale();
            Console.WriteLine("\n");
            creditPurchase.ProcessSale();

            Console.WriteLine("\nMediator Pattern:");
            var manager = new ManagerMediator();

            var client = new Client(manager);
            var mechanic = new Mechanic(manager);
            var cashier = new Cashier(manager);

            manager.Client = client;
            manager.Mechanic = mechanic;
            manager.Cashier = cashier;

            client.RequestRepair();

            Console.WriteLine("\nChain of responsibility");
            var manager1 = new Manager();
            var bussinesPartner = new BusinessPartner();
            var owner = new Owner();

            manager1.SetNextHandler(bussinesPartner);
            bussinesPartner.SetNextHandler(owner);

            manager1.ProcessRequest(12);

            Console.WriteLine("\nObserver pattern");
            var regularCustomer = new RegularCustomer();
            var vipCustomer = new VipCustomer();
            var regularCustomer1 = new RegularCustomer();
            var carDealership = new CarDealership();

            carDealership.RegisterObserver(regularCustomer);
            carDealership.RegisterObserver(vipCustomer);
            carDealership.RegisterObserver(regularCustomer1);

            carDealership.NotifyObservers("product");

            Console.WriteLine("\nStrategy pattern:");
            var planeStrategy = new PlaneStrategy();
            var shipStrategy = new ShipStrategy();
            var truckStrategy = new TruckStrategy();

            var shoppingCartPlane = new ShoppingCart();
            shoppingCartPlane.SetDeliveryStrategy(planeStrategy);
            var shoppingCartShip = new ShoppingCart();
            shoppingCartShip.SetDeliveryStrategy(shipStrategy);
            var shoppingCartTruck = new ShoppingCart();
            shoppingCartTruck.SetDeliveryStrategy(truckStrategy);

            shoppingCartPlane.CalculateShipping();
            shoppingCartShip.CalculateShipping();
            shoppingCartTruck.CalculateShipping();

            Console.WriteLine("\nCommand Pattern:");
            Engine engine = new Engine();
            Lights lights = new Lights();

            ICommand engineCommand = new StartEngineCommand(engine);
            ICommand lightsCommand = new TurnOnLightsCommand(lights);

            CarRemote carRemote = new CarRemote();

            carRemote.SetCommand(engineCommand);
            carRemote.Invoke();
            carRemote.SetCommand(lightsCommand);
            carRemote.Invoke();

            Console.WriteLine("\nState pattern:");
            var orderContext = new OrderContext();
            orderContext.Ship();
            orderContext.Pay();
            orderContext.Ship();

            Console.WriteLine("\nVisitor Pattern:");
            List<ICarElement> elements = new List<ICarElement>();
            elements.Add(new EngineElement());
            elements.Add(new BodyElement());

            IVisitor taxVisitor = new TaxVisitor();
            IVisitor mechanicVisitor = new MechanicVisitor();

            foreach (var element in elements)
            {
                element.Accept(taxVisitor);
                element.Accept(mechanicVisitor);
            }

            Console.WriteLine("\nIterator pattern:");
            var car1 = new Car("Red", "Sport");
            var car2 = new Car("Blue", "SUV");
            var carCatalog = new CarCatalog();
            carCatalog.AddItem(car1);
            carCatalog.AddItem(car2);
            var carCatalogIterator = carCatalog.GetIterator();
            while (carCatalogIterator.HasNext())
            {
                var car = carCatalogIterator.Next();
                car.DisplayInfo();


            }

            Console.WriteLine("\nMemento pattern:");
            var carConfigurator = new CarConfigurator();
            carConfigurator.ShowConfiguration();
            var carMemento = carConfigurator.SaveState();
            carConfigurator.Color = "Red";
            carConfigurator.WheelsRadius = 18;
            carConfigurator.Interior = "Leather";
            carConfigurator.ShowConfiguration();
            carConfigurator.RestoreState(carMemento);
            carConfigurator.ShowConfiguration();
        }
    }
}

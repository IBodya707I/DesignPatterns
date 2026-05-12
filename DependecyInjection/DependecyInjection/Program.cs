using Microsoft.Extensions.DependencyInjection;
using DependecyInjection.Services.Core;
using DependecyInjection.Services.Documents;
using DependecyInjection.Services.Finance;
using DependecyInjection.Services.Sales;

namespace DependecyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<ILogger, ConsoleLogger>();
            services.AddSingleton<IPrinterService, PrinterService>();
            services.AddSingleton<ITaxCalculator, TaxCalculator>();

            services.AddTransient<IFinanceService, FinanceService>();
            services.AddTransient<IDocumentProcessor, DocumentProcessor>();
            services.AddTransient<ISalesManager, SalesManager>();
            services.AddTransient<IPricingEngine, PricingEngine>();
            services.AddTransient<ICreditChecker, CreditChecker>();
            services.AddTransient<IInventorySystem, InventorySystem>();
            services.AddTransient<DealershipApp>();

            var serviceProvider = services.BuildServiceProvider();

            var app = serviceProvider.GetService<DealershipApp>();
            app.Run();

        }
    }
}

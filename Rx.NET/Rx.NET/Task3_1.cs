using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task3_1
    {
        record Product(string Name, double PriceUsd);
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product("Навушники Sony", 49.99),
                new Product("Клавіатура Logitech", 129.00),
                new Product("Монітор LG 27", 399.00),
                new Product("USB-хаб Anker", 35.00),
                new Product("Веб-камера Logitech", 149.00),
                new Product("Килимок для миші", 18.00),
                new Product("SSD Samsung 1TB", 110.00)
            };
            products.ToObservable()
                .Where(p => p.PriceUsd > 100)
                .Select(p =>{
                    double priceUah = p.PriceUsd * 41.5;
                    return $"{p.Name} -- {priceUah} грн (є в наявності)";
                })
                .Subscribe(result => Console.WriteLine(result));
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task3_2
    {
        record FoodOrder(string OrderId, List<string> Items);
        public static void Run()
        {
            var orders = new List<FoodOrder>
            {
                new FoodOrder("ZAM-01", new List<string> { "Піца Маргарита", "Кола 0.5л" }),
                new FoodOrder("ZAM-02", new List<string> { "Борщ", "Вареники", "Компот" }),
                new FoodOrder("ZAM-03", new List<string> { "Суші-сет 20шт", "Місо-суп" })
            };
            Console.WriteLine("Part A:");
            orders.ToObservable()
                .SelectMany(o => o.Items)
                .Subscribe(item => Console.WriteLine(">> " + item));
            Console.WriteLine("Part B:");
            Console.WriteLine("SelectMany");
            orders.ToObservable()
                .SelectMany(o => o.Items.ToObservable().Delay(TimeSpan.FromMilliseconds(500)))
                .Subscribe(item => Console.WriteLine(item));
            Thread.Sleep(1000); 
            Console.WriteLine("Select + Concat");
            orders.ToObservable()
                .Select(o => o.Items.ToObservable().Delay(TimeSpan.FromMilliseconds(500)))
                .Concat()
                .Subscribe(item => Console.WriteLine(item));
            Thread.Sleep(2000);
            Console.WriteLine();

        }
    }
}

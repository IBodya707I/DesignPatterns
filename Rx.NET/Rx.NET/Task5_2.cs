using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task5_2
    {
        record ServiceCall(string ServiceName, int DelayMs);
        public static void Run()
        {
            var services = new List<ServiceCall>
            {
                new ServiceCall("UserService", 800),
                new ServiceCall("OrderService", 1200),
                new ServiceCall("RecommendationService", 600)
            };
            Console.WriteLine("Part A:");
            var sw1 = Stopwatch.StartNew();
            services.ToObservable()
                .Select(s => Observable.Return(s.ServiceName).Delay(TimeSpan.FromMilliseconds(s.DelayMs)))
                .Concat()
                .Subscribe(
                res => Console.WriteLine($"(+) {res} відповів"),
                () =>
                {
                    sw1.Stop();
                    Console.WriteLine($"Усі сервіси відповіли за {sw1.ElapsedMilliseconds} мс");
                }
                );
            Thread.Sleep(4000);
            Console.WriteLine("Part B:");
            var sw2 = Stopwatch.StartNew();
            services.ToObservable()
                .SelectMany(s => Observable.Return(s.ServiceName).Delay(TimeSpan.FromMilliseconds(s.DelayMs)))
                .Subscribe( res => Console.WriteLine($"[Потік {Thread.CurrentThread.ManagedThreadId}] (+) {res} відповів"),
                                () =>
                {
                    sw2.Stop();
                    Console.WriteLine($"Усі сервіси відповіли за {sw2.ElapsedMilliseconds} мс");
                }
                );
            Thread.Sleep(2000);

        }
    }
}

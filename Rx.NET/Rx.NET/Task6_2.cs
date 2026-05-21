using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task6_2
    {
        public static void Run()
        {
            Console.WriteLine("Part A:");
            var events = new[] {
                "LOGIN:user1", "CLICK:btn_buy", "VIEW:product_42", "LOGIN:user2", "LOGOUT:user1",
                "CLICK:btn_cart", "VIEW:product_7", "LOGIN:user3", "CLICK:btn_pay", "LOGOUT:user2",
                "LOGIN:user4", "VIEW:product_1"
            };
            int batchCounter = 1;
            int totalSaved = 0;
            events.ToObservable()
                .Buffer(5)
                .Subscribe(
                batch =>
                {
                    string items = String.Join(", ", batch);
                    Console.WriteLine($"[DB] Batch INSERT #{batchCounter++}: [{items}]");
                    totalSaved += batch.Count();
                });
            Console.WriteLine("Збережено подій:" + totalSaved);

            Console.WriteLine("Part B:");
            int processed = 0;
            int dropped = 0;
            bool isBusy = false;
            var fastproducer = Observable.Range(0, 1000);
            fastproducer.Where(item =>
            {
                if (isBusy)
                {
                    dropped++;
                   
                    return false;
                }
                isBusy = true;
                return true;
            })
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(item =>
                {
                    
                    processed++;
                    Thread.Sleep(10);
                    isBusy = false;
                });
            Console.WriteLine("Оброблено " + processed);
            Console.WriteLine("Відкинуто " + dropped);
            Console.WriteLine();
        }
    }
}

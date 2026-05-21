using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task2_2
    {
        public static void Run()
        {
            string[] matches = {
            "Динамо 2:1 Шахтар",
            "Шахтар 3:0 Металіст",
            "Зоря 1:1 Ворскла",
            "Дніпро 2:0 Чорноморець",
            "Карпати 1:2 Рух"
        };

            var baseStream = Observable.Interval(TimeSpan.FromSeconds(1))
                .Take(matches.Length)          
                .Select(i => matches[i]);      

            Console.WriteLine("--- Cold stream ---");

            baseStream.Subscribe(msg => Console.WriteLine($"[Глядач 1] {msg}"));

            Thread.Sleep(2500);

            baseStream.Subscribe(msg => Console.WriteLine($"[Глядач 2] {msg}"));

            Thread.Sleep(6000);

            Console.WriteLine("\n-------------------------------------------------\n");

            Console.WriteLine("--- Hot stream ---");

            var hotStream = baseStream.Publish();

            var connection = hotStream.Connect();

            hotStream.Subscribe(msg => Console.WriteLine($"[Глядач 1 (Ефір)] {msg}"));

            Thread.Sleep(2500);

            hotStream.Subscribe(msg => Console.WriteLine($"[Глядач 2 (Ефір)] {msg}"));

            Thread.Sleep(4000);

            connection.Dispose();
            Console.WriteLine();
        }
    }
}

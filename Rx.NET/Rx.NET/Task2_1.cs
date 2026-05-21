using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Reactive.Disposables;

namespace Rx.NET
{
    internal class Task2_1
    {
        public static void Run()
        {
            var atmObservable = Observable.Create<string>(observer =>
            {
                observer.OnNext("Вставте картку");
                observer.OnNext("Введіть PIN-код");
                observer.OnNext("Оберіть суму: 500 грн");
                observer.OnNext("Видача готівки...");
                observer.OnNext("Дякуємо! Заберіть картку");

                observer.OnCompleted();

                return Disposable.Empty;
            });

            Console.WriteLine("[БАНКОМАТ] Сесію розпочато");

            atmObservable.Subscribe(
                onNext: msg => Console.WriteLine($">> {msg}"),
                onError: ex => Console.WriteLine($"[БАНКОМАТ] Помилка: {ex.Message}"),
                onCompleted: () => Console.WriteLine("[БАНКОМАТ] Сесію завершено")
            );

            Console.WriteLine();
        }
    }
}

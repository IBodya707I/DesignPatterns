using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task7_1
    {
        public static void Run()
        {
            var currencyService = Observable.Create<string>(emitter =>
            {
                emitter.OnNext("USD -> UAH: 41.50");
                emitter.OnNext("EUR -> UAH: 44.20");
                emitter.OnError(new Exception("Сервіс тимчасово недоступний"));
                emitter.OnNext("GBP -> UAH: 52.10");

                return Disposable.Empty;
            }); 
            currencyService.Catch(Observable.Return("Використовується кешований курс: USD -> UAH: 41.00"))
                .Subscribe(
                res => Console.WriteLine(res)
                );
            Console.WriteLine();
            var backupService = new[] { "JPY -> UAH: 0.27", "PLN -> UAH: 10.30" }.ToObservable();
            currencyService.Catch(backupService)
                .Subscribe(
                res => Console.WriteLine(res)
                );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rx.NET
{
    internal class Task7_2
    {
        public static void Run()
        {
            int attemptCount = 0;
            var unstableApiCall = Observable.Create<string>(emitter =>
            {
                attemptCount++;
                Console.WriteLine($"[ПОВТОР] Спроба #{attemptCount}");
                if (attemptCount < 4)
                    emitter.OnError(new Exception("Connection timeout"));
                else
                {
                    emitter.OnNext("(+) Відповідь API: {status: 'ok', data: [...]}");
                    emitter.OnCompleted();
                }
                return Disposable.Empty;
            });
            unstableApiCall.RetryWhen(
                errors => errors.Zip(Observable.Range(1, 4), (error, attemptIndex) => new { error, attemptIndex })
                .SelectMany(errorInfo =>
                {
                    if (errorInfo.attemptIndex == 4)
                    {
                        return Observable.Throw<long>(errorInfo.error);
                    }
                    int delaySeconds = (int)Math.Pow(2, errorInfo.attemptIndex - 1);
                    Console.WriteLine($"Очікуємо {delaySeconds} сек перед повтором...");
                    return Observable.Timer(TimeSpan.FromSeconds(delaySeconds));
                }))
                .Subscribe(
                    res => Console.WriteLine(res),
                    error => Console.WriteLine($"Помилка: {error.Message}"));
            Thread.Sleep(8000);

        }
    }
}

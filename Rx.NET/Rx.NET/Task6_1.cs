using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace Rx.NET
{
    internal class Task6_1
    {
        public static void Run()
        {
            string[] inputs = { "К", "Ки", "Киї", "Київ", "Київ ", "Київ К", "Київ Ки" };
            int[] delays = { 50, 80, 120, 100, 400, 60, 350 };
            var keystrokers = Observable.Create<string>(async (observer, token) =>
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (token.IsCancellationRequested)
                        break;
                    observer.OnNext(inputs[i]);
                    await Task.Delay(delays[i]);
                }
                observer.OnCompleted();
            }
            );
            keystrokers.Throttle(TimeSpan.FromMilliseconds(300))
                .Subscribe(
                query => Console.WriteLine("Пошук по API: " + query),
                () => Console.WriteLine("Пошук завершено"));
            Thread.Sleep(2000);
            Console.WriteLine();
        }
    }
}

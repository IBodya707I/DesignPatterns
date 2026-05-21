using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;

namespace Rx.NET
{
    internal class Task4_1
    {
        static IObservable<string> GetUser(int id)
        {
            if (id > 0)
            {
                return Observable.Return(id.ToString());

            }
            else
            {
                return Observable.Throw<string>(new ArgumentException("ID має бути додатнім числом"));
            }
        }
        public static void Run()
        {
            GetUser(42).Subscribe(
                user => Console.WriteLine($"Отримано користувача: {user}"),
                error => Console.WriteLine($"Помилка: {error.Message}")
            );
            GetUser(-1).Subscribe(
                    user => Console.WriteLine($"Отримано користувача: {user}"),
                    error => Console.WriteLine($"Помилка: {error.Message}")
                );
            Console.WriteLine();
        }
    }
}

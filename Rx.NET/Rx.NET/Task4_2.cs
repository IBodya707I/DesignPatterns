using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;
using System.Reactive;

namespace Rx.NET
{
    internal class Task4_2
    {
        static IObservable<string> FindInCache(string key)
        {
            return key switch
            {
                "user:1" => Observable.Return("{'name': 'Леся', 'age':28}"),
                "user:2" => Observable.Empty<string>(),
                _ => Observable.Throw<string>(new Exception("Redis недоступний"))
            };
        }
        static IObservable<Unit> ValidateInput()
        {
            Console.WriteLine("[ПОШУК] Перевірка даних...");
            Console.WriteLine("(+) Дані валідні");
            return Observable.Return(Unit.Default);
        }
        static IObservable<Unit> SaveToDatabase(bool simulateSuccess)
        {
            Console.WriteLine("[DB] Збереження в БД...");
            if (simulateSuccess)
            {
                Console.WriteLine("(+) Збережено");
                return Observable.Return(Unit.Default);
            }

            return Observable.Throw<Unit>(new Exception("База даних відхилила запит"));
        }
        static IObservable<string> GenerateToken()
        {
            return Observable.Return("eyJhbGci0iJIUzI1NiIsInR5cCI6IkpXVCJ9.demo");
        }
        public static void Run()
        {
            string[] keys = { "user:1", "user:2", "user:error" };
            foreach (var key in keys)
            {
                FindInCache(key)
                    .DefaultIfEmpty("Дані завантажуються з БД...")
                    .Subscribe(
                        data => Console.WriteLine($"[CACHE] Результат для '{key}': {data}"),
                        error => Console.WriteLine($"[CACHE] Помилка для '{key}': {error.Message}")
                    );
            }
            Console.WriteLine();

            ValidateInput()
                .SelectMany(_ => SaveToDatabase(simulateSuccess: true))
                .SelectMany(_ => GenerateToken())
                .Subscribe(
                    token => Console.WriteLine($"Отримано токен: {token}"),
                    error => Console.WriteLine($"Помилка: {error.Message}")
                );
            Console.WriteLine();

            ValidateInput()
                .SelectMany(_ => SaveToDatabase(simulateSuccess: false))
                .SelectMany(_ => GenerateToken())
                .Subscribe(
                    token => Console.WriteLine($"Отримано токен: {token}"),
                    error => Console.WriteLine($"Помилка: {error.Message}")
                );
            Console.WriteLine();
        }
    }
}

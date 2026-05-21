using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;

namespace Rx.NET
{
    internal class Task1_2
    {
        public static void Run()
        {
            var cities = new List<string>
            {
                "Київ", "Харків", "Одеса", "Дніпро", "Запоріжжя",
                "Кривий Ріг", "Миколаїв", "Херсон", "Кропивницький",
                "Черкаси", "Суми", "Хмельницький", "Чернівці", "Каховка"
            };

            Console.WriteLine("--- 1. for-loop ---");
            var imperativeResult = new List<string>();
            foreach (var city in cities)
            {
                if (city.StartsWith("К"))
                {
                    imperativeResult.Add(city.ToUpper());
                }
            }
            imperativeResult.Sort();
            foreach (var city in imperativeResult)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n--- 2. LINQ ---");
            cities.Where(c => c.StartsWith("К"))
                .Select(c => c.ToUpper())
                .OrderBy(c => c)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine("\n--- 3. Rx.NET ---");
            cities.ToObservable()
                .Where(c => c.StartsWith("К"))     
                .Select(c => c.ToUpper())          
                .ToList()                          
                .Subscribe(list =>
                {
                    foreach (var city in list.OrderBy(c => c))
                    {
                        Console.WriteLine(city);
                    }
                });
            Console.WriteLine();
        }
    }
}

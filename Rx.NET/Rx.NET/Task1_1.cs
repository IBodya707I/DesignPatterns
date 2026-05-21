using System;
using System.Collections.Generic;
using System.Text;

namespace Rx.NET
{
    internal class Task1_1
    {
        enum Status { DELIVERED, PENDING, CANCELLED }
        record Order(string Id, Status Status, double Amount);
        public static void Run()
        {
            Console.WriteLine("=== Завдання 1.1: LINQ ===");

            var orders = new List<Order>
            {
                new Order("O-001", Status.DELIVERED, 1500.00),
                new Order("O-002", Status.PENDING, 300.00),
                new Order("O-003", Status.CANCELLED, 75.00),
                new Order("O-004", Status.DELIVERED, 2200.00),
                new Order("O-005", Status.PENDING, 450.00),
                new Order("O-006", Status.DELIVERED, 980.00)
            };

            int count = orders.Count(o => o.Status == Status.DELIVERED);

            double totalDelivered = orders
                .Where(o => o.Status == Status.DELIVERED)
                .Sum(o => o.Amount);

            Console.WriteLine($"Виконаних замовлень: {count}");
            Console.WriteLine($"Загальна сума: {totalDelivered}");
            Console.WriteLine();
        }
    }
}

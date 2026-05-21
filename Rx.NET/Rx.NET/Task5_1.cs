using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Reactive.Concurrency;

namespace Rx.NET
{
    internal class Task5_1
    {
        static string DownloadImage(string img)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] [ЗАВАНТ] Завантаження: {img}");
            return img;
        }

        static string CompressImage(string img)
        {
            Thread.Sleep(500);
            Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] [СТИСК] Стиснення: {img}");
            return img;
        }

        static void DisplayImage(string img)
        {
            Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] [ФОТО] Відображення: {img}");
        }
        public static void Run()
        {
            var images = new[] { "photo_1.jpg", "photo_2.jpg", "photo_3.jpg" };
            images.ToObservable()
                .SubscribeOn(ThreadPoolScheduler.Instance)
                .Select(img => DownloadImage(img))
                .ObserveOn(TaskPoolScheduler.Default)
                .Select(img => CompressImage(img))
                .ObserveOn(CurrentThreadScheduler.Instance)
                .Subscribe(img => DisplayImage(img));
                Thread.Sleep(5000);
        }
    }
}

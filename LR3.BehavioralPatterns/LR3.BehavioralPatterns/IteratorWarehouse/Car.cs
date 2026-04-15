using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.IteratorWarehouse
{
    internal class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }   
        public Car() { }
        public Car(string color, string model)
        {
            this.Color = color;
            this.Model = model;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Model: {Model}, Color: {Color}");
        }
    }
}

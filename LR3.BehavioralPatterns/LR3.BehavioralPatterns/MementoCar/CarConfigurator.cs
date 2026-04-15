using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MementoCar
{
    internal class CarConfigurator
    {
        public string Color { get; set; } = "Not selected";
        public int WheelsRadius { get; set; } = 0;
        public string Interior { get; set; } = "Not selected";
        public CarConfigurator() { }
        public CarMemento SaveState()
        {
                return new CarMemento(Color, WheelsRadius, Interior);
        }
        public void RestoreState(CarMemento memento)
        {
            Color = memento.Color;
            WheelsRadius = memento.WheelsRadius;
            Interior = memento.Interior;
        }
        public void ShowConfiguration()
        {
            Console.WriteLine($"Current configuration: Color - {Color}, Wheels Radius - {WheelsRadius}, Interior - {Interior}");
        }
    }
}

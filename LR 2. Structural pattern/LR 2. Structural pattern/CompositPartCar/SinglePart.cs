using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.CompositPartCar
{
    internal class SinglePart: ICarPart
    {
        private string _name;
        private double _price;
        public SinglePart(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public void Display(int indent = 0)
        {
            Console.WriteLine(new string('-', indent) + _name + " - " + _price);
        }
        public double GetPrice()
        {
            return _price; 
        }
    }
}

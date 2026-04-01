using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.CompositPartCar
{
    internal class CompositPart: ICarPart
    {
        private string _name;
        private List<ICarPart> _children = new List<ICarPart>();
        public CompositPart(string name)
        {
            _name = name;
        }
        public void AddPart(ICarPart part)
        {
            _children.Add(part);
        }
        public void RemovePart(ICarPart part)
        {
            _children.Remove(part);
        }
        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + _name);
            foreach (var child in _children)
            {
                child.Display(depth + 2);
            }
        }
        public double GetPrice()
        {
            double totalPrice = 0;
            foreach (var child in _children)
            {
                totalPrice += child.GetPrice();
            }
            return totalPrice;
        }
    }
}

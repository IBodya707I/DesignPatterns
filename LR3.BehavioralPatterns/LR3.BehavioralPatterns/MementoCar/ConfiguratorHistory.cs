using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.MementoCar
{
    internal class ConfiguratorHistory
    {
        private Stack<CarMemento> history = new Stack<CarMemento>();
        public void SaveState(CarMemento memento)
        {
            history.Push(memento);
        }
        public CarMemento RestoreState()
        {
            if (history.Count > 0)  
            {
                return history.Pop();
            }
            else
            {
                Console.WriteLine("No previous configuration to restore.");
                return null;
            }
        }
    }
}

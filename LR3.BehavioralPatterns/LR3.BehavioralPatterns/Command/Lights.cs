using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.Command
{
    internal class Lights
    {
        public Lights() { }
        public void TurnOnLights()
        {
            Console.WriteLine("Lights are turned on.");
        }
    }
}

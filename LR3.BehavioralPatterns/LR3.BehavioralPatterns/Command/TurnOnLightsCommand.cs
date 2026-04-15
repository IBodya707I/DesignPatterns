using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.Command
{
    internal class TurnOnLightsCommand: ICommand
    {
        private Lights _lights;
        public TurnOnLightsCommand(Lights lights)
        {
            _lights = lights;
        }
        public void Execute()
        {
            _lights.TurnOnLights();
        }
    }
}

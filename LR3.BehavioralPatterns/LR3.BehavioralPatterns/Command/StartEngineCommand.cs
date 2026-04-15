using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.Command
{
    internal class StartEngineCommand: ICommand
    {
        private Engine _engine;
        public StartEngineCommand(Engine engine)
        {
            _engine = engine;
        }
        public void Execute()
        {
            _engine.Start();
        }
    }
}

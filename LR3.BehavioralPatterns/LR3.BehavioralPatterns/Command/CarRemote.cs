using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.Command
{
    internal class CarRemote
    {
        private ICommand _command;
        public CarRemote() { }
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Invoke()
        {
            if (_command != null)
            {
                _command.Execute();
            }
            else
            {
                Console.WriteLine("No command set");
            }
        }
    }
}

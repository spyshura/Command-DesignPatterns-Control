using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Control.ControllerSystems
{
    
    public class Teapot
    {
        public void TurnOn()
        {
            Console.WriteLine("Чайник включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Чайник выключен");
            State = State.Off;
        }

        public State State { get; set; }
    }
}

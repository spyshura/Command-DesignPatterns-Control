using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Control.ControllerSystems
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }

        public State State { get; set; }
    }
}

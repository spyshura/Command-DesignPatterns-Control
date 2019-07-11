﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Control.ControllerSystems
{
    public enum LightState
    {
        Off = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }
    public class Light
    {
        public void ToggleLight()
        {
            switch (State)
            {
                case LightState.Off:
                    State = LightState.Low;
                    break;
                case LightState.Low:
                    State = LightState.Medium;
                    break;
                case LightState.Medium:
                    State = LightState.High;
                    break;
                case LightState.High:
                    State = LightState.Off;
                    break;
            }
            PrintLight();
        }

        public void TurnOff()
        {
            State = LightState.Off;
            PrintLight();
        }

        public LightState State { get; set; }
        public void SetState(LightState state)
        {
            State = state;
            PrintLight();
        }

        private void PrintLight()
        {
            switch (State)
            {
                case LightState.Low:
                    Console.WriteLine("Свет тусклый");
                    break;
                case LightState.Medium:
                    Console.WriteLine("Свет средний");
                    break;
                case LightState.High:
                    Console.WriteLine("Свет яркий");
                    break;
                case LightState.Off:
                    Console.WriteLine("Свет выключен");
                    break;
            }
            }
    }
}

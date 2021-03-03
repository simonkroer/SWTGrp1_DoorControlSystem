using System;
using System.Collections.Generic;
using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Models
{
    public class Door : IDoor
    {
        public bool Opened { get; set; } = false;
        private IDoorControl _doorControl;

        public Door()
        {
        }

        public void Open()
        {
            Console.WriteLine("Door opening");
            Opened = true;
            Notify();
        }

        public void Close()
        {
            Console.WriteLine("Door closing");
            Opened = false;
        }

        public void Attach(IDoorControl doorControl)
        {
            _doorControl = doorControl;
        }

        public void Detach(IDoorControl doorControl)
        {
            _doorControl = null;
        }

        public void Notify()
        {
            _doorControl.Update(this);
        }
    }
}

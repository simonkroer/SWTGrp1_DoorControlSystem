using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControlSystem
{
    public class Door : IDoor
    {
        private DoorControl _doorControl;

        public Door(DoorControl doorControl)
        {
            _doorControl = doorControl;
        }

        public void Open()
        {
            Console.WriteLine("Door opening");
            
        }

        public void Close()
        {
            Console.WriteLine("Door closing");
        }
    }
}

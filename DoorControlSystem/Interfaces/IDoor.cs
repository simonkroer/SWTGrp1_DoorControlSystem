using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControlSystem.Interfaces
{
    public interface IDoor
    {
        public bool Opened { get; set; }
        public void Open();

        public void Close();
        void Attach(IDoorControl doorControl);

        void Detach(IDoorControl doorControl);
    }
}

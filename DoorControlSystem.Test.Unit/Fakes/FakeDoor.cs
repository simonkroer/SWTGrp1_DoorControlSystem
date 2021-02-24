using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Test.Unit.Fakes
{
    public class FakeDoor : IDoor
    {
        public bool Opened { get; set; }

        public void Open()
        {

        }

        public void Close()
        {

        }

        public void Attach(IDoorControl doorControl)
        {

        }

        public void Detach(IDoorControl doorControl)
        {

        }

        public void Notify()
        {

        }

        public int CountOpen { get; set; } = 0;
        public int CountClose { get; set; } = 0;
        
    }
}
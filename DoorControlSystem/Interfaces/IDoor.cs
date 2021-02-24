using Microsoft.VisualBasic;

namespace DoorControlSystem.Interfaces
{
    public interface IDoor
    {
        public bool Open();
        public bool Close();
    }
}
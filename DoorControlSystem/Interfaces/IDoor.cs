using Microsoft.VisualBasic;

namespace DoorControlSystem
{
    public interface IDoor
    {
        public bool Open();
        public bool Close();
    }
}
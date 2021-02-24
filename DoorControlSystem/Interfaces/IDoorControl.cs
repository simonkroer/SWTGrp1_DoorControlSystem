namespace DoorControlSystem.Interfaces
{
    public interface IDoorControl
    {
        public bool RequestEntry(string id);
        void Breach();
        void Update(IDoor door);
    }
}
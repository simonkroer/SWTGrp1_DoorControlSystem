namespace DoorControlSystem.Interfaces
{
    public interface IDoorControl
    {
        public bool RequestEntry(string id);
        void Update(IDoor door);

    }
}
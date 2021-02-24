namespace DoorControlSystem.Interfaces
{
    public interface IEntryNotification
    {
        public void NotifyEntryGranted();
        public void NotifyEntryDenied();
    }
}
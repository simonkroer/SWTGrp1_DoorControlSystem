namespace DoorControlSystem
{
    public interface IEntryNotification
    {
        public void NotifyEntryGranted();
        public void NotifyEntryDenied();
    }
}
namespace DoorControlSystem
{
    public partial interface IEntryNotification
    {
        public void NotifyEntryGranted();
        public void NotifyEntryDenied();
    }
}
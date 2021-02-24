namespace DoorControlSystem.Interfaces
{
    public partial interface IEntryNotification
    {
        public void NotifyEntryGranted(string id);
        public void NotifyEntryDenied(string id);
    }
}
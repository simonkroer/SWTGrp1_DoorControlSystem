namespace DoorControlSystem.Interfaces
{
    public partial interface IEntryNotification
    {
        public void NotifyEntryGranted(IUserValidation id);
        public void NotifyEntryDenied(IUserValidation id);
    }
}
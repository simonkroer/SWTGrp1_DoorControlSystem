using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Test.Unit.Fakes
{
    public class FakeEntryNotification : IEntryNotification
    {
        private int CountNotifyEntryGranted { get; set; } = 0;
        private int CountNotifyEntryDenied { get; set; } = 0;
        public void NotifyEntryGranted(string id)
        {
            ++CountNotifyEntryGranted;
        }

        public void NotifyEntryDenied(string id)
        {
            ++CountNotifyEntryGranted;
        }
    }
}
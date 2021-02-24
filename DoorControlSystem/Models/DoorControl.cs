using Microsoft.VisualBasic;
using System.Threading;

namespace DoorControlSystem.Models
{
    public class DoorControl
    {
        private IDoor _door;
        private IAlarm _alarm;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        public DoorControl(IDoor door, IAlarm alarm, IEntryNotification entryNotification,
            IUserValidation userValidation)
        {
            _door = door;
            _alarm = alarm;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
        }

        public bool RequestEntry(string id)
        {
            if (_userValidation.ValidateEntryRequest())
            {
                _entryNotification.NotifyEntryGranted();
                _door.OpenDoor();
                Thread.Sleep(3000);
                _door.CloseDoor();
            }
            else
            {
                _entryNotification.NotifyEntryDenied();
            }
        }

    }
}
using Microsoft.VisualBasic;

namespace DoorControlSystem
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

        RequestEntry(string id)
        {

        }
    }
}
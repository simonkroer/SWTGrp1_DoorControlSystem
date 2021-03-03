using System.Threading;
using DoorControlSystem;
using DoorControlSystem.Interfaces;
using DoorControlSystem.Models;

namespace DoorControlSystem.Models
{
    public class DoorControl : IDoorControl
    {
        private IDoor _door;
        private IAlarm _alarm;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;
        private bool _entryState; // Sets state according to ValidateEntryRequest
        public int _noAlarmCalls = 0;

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
            var entryState = _userValidation.ValidateEntryRequest(id);
            _entryState = entryState;

            if (_entryState)
            {
                _entryNotification.NotifyEntryGranted(id);
                _door.Open(); // Door Notifies DoorControl
                _entryState = false;
                Thread.Sleep(3000);
                _door.Close();
            }
            else
            {
                _entryNotification.NotifyEntryDenied(id);
            }

            return entryState;
        }

        public void Update(IDoor door)
        {
            if (!_entryState && door.Opened) // if entryState is false there is a breach
            {
                ++_noAlarmCalls;
                Breach();
            }
        }

        public void Breach()
        {
            _alarm.RaiseAlarm();

        }

    }
}
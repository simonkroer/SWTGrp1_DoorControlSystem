﻿using DoorControlSystem;
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
                _door.Open();

            }
        }
    }
}
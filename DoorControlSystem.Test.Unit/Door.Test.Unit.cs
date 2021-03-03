using System;
using System.Collections.Generic;
using System.Text;
using DoorControlSystem.Interfaces;
using DoorControlSystem.Models;
using NSubstitute;
using NUnit.Framework;

namespace DoorControlSystem.Test.Unit
{
    class DoorTestUnit
    {
        private IDoorControl _doorControl;
        private Door _uut;
        private IAlarm _alarm;
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            _uut = new Door();
            _alarm = Substitute.For<IAlarm>();
            _door = Substitute.For<IDoor>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _userValidation = Substitute.For<IUserValidation>();
            _doorControl = Substitute.For<IDoorControl>();
        }

    }
}

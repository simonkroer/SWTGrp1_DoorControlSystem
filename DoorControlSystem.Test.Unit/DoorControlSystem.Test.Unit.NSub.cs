using DoorControlSystem.Models;
using DoorControlSystem.Interfaces;
using DoorControlSystem.Test.Unit.Fakes;
using NSubstitute;
using NSubstitute.Exceptions;
using NUnit.Framework;

namespace DoorControlSystem.Test.Unit.NSub
{
    public class Tests
    {
        private DoorControl _uut;
        private IAlarm _alarm;
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            _alarm = Substitute.For<IAlarm>();
            _door = Substitute.For<IDoor>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _userValidation = Substitute.For<IUserValidation>();
            _uut = new DoorControl(_door, _alarm, _entryNotification, _userValidation);
        }

        // Simon
        [Test]
        public void RequestEntry_ValidId_ReturnTrue()
        {
            _userValidation.ValidateEntryRequest("valid").Returns(true);
            Assert.That(_uut.RequestEntry("valid"), Is.EqualTo(true));
        }

        // Jefe
        [Test]
        public void RequestEntry_InvalidId_ReturnFalse()
        {
            _userValidation.ValidateEntryRequest("invalid").Returns(false);
        }

        // Camilla
        [Test]
        public void RequestEntry_ValidId_NotifyEntryGranted()
        {
            
        }
        
        // Thomas
        [Test]
        public void RequestEntry_InvalidId_NotifyEntryDenied()
        {
            _uut.RequestEntry("wrong id");
            _entryNotification.Received(1).NotifyEntryDenied(Arg.Any<string>());
        }

        // Simon
        [Test]
        public void RequestEntry_validId_DoorOpens()
        {
            _userValidation.ValidateEntryRequest("valid").Returns(true);
            _uut.RequestEntry("valid");
            _door.Received(1).Open();

        }

        // Jefe
        [Test]
        public void RequestEntry_validId_DoorCloses()
        {
            _userValidation.ValidateEntryRequest("valid").Returns(true);
            _uut.RequestEntry("valid");
            _door.Received(1).Close();

            
            // Assert.That(_door.CountClose, Is.EqualTo(1));
        }

        // Camilla
        [Test]
        public void RequestEntry_invalidId_DoorDoesNotOpen()
        {
            
        }

        // Thomas
        [Test]
        public void DoorBreached_RaiseAlarmCalled()
        {
            _uut.Breach();
            _alarm.Received(1).RaiseAlarm();
        }

        // free for all
        [Test]
        public void Update_entryStateFalseDoorOpenedTrue_RaiseAlarmCalled()
        {
            _door.Opened = true;
            _uut.Update(_door);
            _alarm.Received(1).RaiseAlarm();
        }

        public void Update_entryStateTrueDoorOpenedTrue_RaiseAlarmCalled()
        {
            _alarm.Received(1).RaiseAlarm();
        }

        // free for all
        [Test]
        public void RequestEntry_InvalidId_Update_RaiseAlarm_notCalled()
        {
            
        }


        // more tests??? - Possible, you can't have to many tests when money isn't an issue. ;-)

    }
}
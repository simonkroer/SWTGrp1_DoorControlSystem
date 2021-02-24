using DoorControlSystem.Interfaces;
using DoorControlSystem.Models;
using DoorControlSystem.Test.Unit.Fakes;
using NUnit.Framework;

namespace DoorControlSystem.Test.Unit
{
    public class DoorControlUnitTest
    {
        private DoorControl _uut;
        private FakeAlarm _alarm;
        private FakeDoor _door;
        private FakeEntryNotification _entryNotification;
        private FakeUserValidation _userValidation;
        private string validId = "valid";
        private string invalidId = "invalid";

        [SetUp]
        public void Setup()
        {
            _alarm = new FakeAlarm();
            _door = new FakeDoor();
            _entryNotification = new FakeEntryNotification();
            _userValidation = new FakeUserValidation();
            _uut = new DoorControl(_door, _alarm, _entryNotification, _userValidation);
        }

        //Value based test
        [Test]
        public void RequestEntry_ValidId_ReturnTrue()
        {
            Assert.That(_uut.RequestEntry(validId));
        }

        //Value based test
        [Test]
        public void RequestEntry_InvalidId_ReturnFalse()
        {
            Assert.That(_uut.RequestEntry(invalidId),Is.EqualTo(false));
        }

        [Test]
        public void RequestEntry_ValidId_NotifyEntryGranted()
        {
            _uut.RequestEntry(validId);
            Assert.That(_entryNotification.CountNotifyEntryGranted, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_InvalidId_NotifyEntryDenied()
        {
            _uut.RequestEntry(invalidId);
            Assert.That(_entryNotification.CountNotifyEntryDenied, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_validId_DoorOpens()
        {
            _uut.RequestEntry(validId);
            Assert.That(_door.CountOpen, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_validId_DoorCloses()
        {
            _uut.RequestEntry(validId);
            Assert.That(_door.CountClose, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_invalidId_DoorDoesNotOpen()
        {
            _uut.RequestEntry(invalidId);
            Assert.That(_door.CountOpen, Is.EqualTo(0));
        }

        [Test]
        public void DoorBreached_RaiseAlarm_Called()
        {
            _uut.Breach();
            Assert.That(_alarm.CountRaiseAlarm, Is.EqualTo(1));
        }

        [Test]
        public void Open_NoRequestIdCalled_RaiseAlarm_Called()
        {
            Door realDoor = new Door();
            realDoor.Attach(_uut);
            realDoor.Open();

            Assert.That(_alarm.CountRaiseAlarm, Is.EqualTo(1));
        }

        [Test]
        public void RequestEntry_InvalidId_Update_RaiseAlarm_notCalled()
        {
            _uut.RequestEntry(invalidId);
            _uut.Update(_door);

            Assert.That(_alarm.CountRaiseAlarm, Is.EqualTo(0));
        }
    }
}
using DoorControlSystem.Models;
using DoorControlSystem.Test.Unit.Fakes;
using NUnit.Framework;

namespace DoorControlSystem.Test.Unit.NSub
{
    public class Tests
    {
        private DoorControl _uut;
        private FakeAlarm _alarm;
        private FakeDoor _door;
        private FakeEntryNotification _entryNotification;
        private FakeUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            _alarm = new FakeAlarm();
            _door = new FakeDoor();
            _entryNotification = new FakeEntryNotification();
            _userValidation = new FakeUserValidation();
            _uut = new DoorControl(_door, _alarm, _entryNotification, _userValidation);
        }

        [Test]
        public void RequestEntry_ValidId_ReturnTrue()
        {
            
        }

        [Test]
        public void RequestEntry_InvalidId_ReturnFalse()
        {
            
        }

        [Test]
        public void RequestEntry_ValidId_NotifyEntryGranted()
        {
            
        }

        [Test]
        public void RequestEntry_InvalidId_NotifyEntryDenied()
        {
            
        }

        [Test]
        public void RequestEntry_validId_DoorOpens()
        {
            
        }

        [Test]
        public void RequestEntry_validId_DoorCloses()
        {
            
        }

        [Test]
        public void RequestEntry_invalidId_DoorDoesNotOpen()
        {
            
        }

        [Test]
        public void DoorBreached_RaiseAlarmCalled()
        {
            
        }

        [Test]
        public void Open_NoRequestIdCalled_RaiseAlarm_Called()
        {
            
        }


        [Test]
        public void RequestEntry_InvalidId_Update_RaiseAlarm_notCalled()
        {
            
        }
    }
}
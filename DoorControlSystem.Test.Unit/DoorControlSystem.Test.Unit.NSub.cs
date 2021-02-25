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

        // Simon
        [Test]
        public void RequestEntry_ValidId_ReturnTrue()
        {
            
        }

        // Jefe
        [Test]
        public void RequestEntry_InvalidId_ReturnFalse()
        {
            
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
            
        }

        // Simon
        [Test]
        public void RequestEntry_validId_DoorOpens()
        {
            
        }

        // Jefe
        [Test]
        public void RequestEntry_validId_DoorCloses()
        {
            
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
            
        }

        // free for all
        [Test]
        public void Open_NoRequestIdCalled_RaiseAlarm_Called()
        {
            
        }

        // free for all
        [Test]
        public void RequestEntry_InvalidId_Update_RaiseAlarm_notCalled()
        {
            
        }

//<<<<<<< HEAD
        // more tests??? - Possible, you can't have to many tests when money isn't an issue. ;-)
//=======
        // more tests???
//>>>>>>> 5b38642b47588567e8d27bfef1037f67948c40eb
    }
}
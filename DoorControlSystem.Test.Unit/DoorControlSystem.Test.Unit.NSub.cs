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
            Assert.That(_uut.RequestEntry("valid"));
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
            _uut.RequestEntry("validId").Returns(true);
            _door.Received(1).Open();

            
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


        // more tests??? - Possible, you can't have to many tests when money isn't an issue. ;-)

    }
}
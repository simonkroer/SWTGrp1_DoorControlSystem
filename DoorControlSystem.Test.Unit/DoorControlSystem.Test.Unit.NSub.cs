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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
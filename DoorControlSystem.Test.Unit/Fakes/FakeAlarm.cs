using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Test.Unit.Fakes
{
    public class FakeAlarm : IAlarm
    {

        public void RaiseAlarm()
        {
            ++CountRaiseAlarm;
        }

        public int CountRaiseAlarm { get; set; } = 0;

    }
}
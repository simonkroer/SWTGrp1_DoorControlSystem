using System;

namespace DoorControlSystem
{
    class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("Alarm raised");
        }
    }
}

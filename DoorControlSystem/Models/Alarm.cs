using System;

namespace DoorControlSystem.Models
{
    class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("Alarm raised");
        }
    }
}

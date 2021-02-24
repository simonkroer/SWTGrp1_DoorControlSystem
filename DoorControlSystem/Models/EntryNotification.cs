using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControlSystem
{
    public class EntryNotification: IEntryNotification
    {
        public void NotifyEntryGranted(IUserValidation id)
        {
            Console.WriteLine($"Entry granted for id: {id}");
        }

        public void NotifyEntryDenied(IUserValidation id)
        {
            Console.WriteLine($"Entry NOT granted for id: {id}");
        }
    }
}

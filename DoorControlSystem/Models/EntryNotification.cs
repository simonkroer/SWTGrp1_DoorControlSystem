using System;
using DoorControlSystem;
using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Models
{
    public class EntryNotification: IEntryNotification
    {
        public void NotifyEntryGranted(string id)
        {
            Console.WriteLine($"Entry granted for id: {id}");
        }

        public void NotifyEntryDenied(string id)
        {
            Console.WriteLine($"Entry NOT granted for id: {id}");
        }
    }
}

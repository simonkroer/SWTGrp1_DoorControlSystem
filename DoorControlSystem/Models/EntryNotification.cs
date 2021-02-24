using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControlSystem
{
    public class EntryNotification: IEntryNotification
    {
        public void NotifyEntryGranted(IUserValidation id)
        {

        }

        public void NotifyEntryDenied(IUserValidation id)
        {

        }
    }
}

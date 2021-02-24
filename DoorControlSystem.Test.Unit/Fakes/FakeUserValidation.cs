using System.Reflection.Metadata.Ecma335;
using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Test.Unit.Fakes
{
    public class FakeUserValidation : IUserValidation
    {
        public bool EntryValidated { get; set; } = true;
        public bool ValidateEntryRequest(string id)
        {
            return EntryValidated;
        }
    }
}
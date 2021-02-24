using DoorControlSystem.Interfaces;

namespace DoorControlSystem.Models
{
    public class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(string id)
        {
            return true;
        }

    }
}
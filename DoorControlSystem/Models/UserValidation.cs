using System;
using DoorControlSystem.Interfaces;
using System.Collections.Generic;

namespace DoorControlSystem.Models
{
    public class UserValidation : IUserValidation
    {
        UserValidation()
        {
            id_.Add("simon");
            id_.Add("camilla");
            id_.Add("thomas");
            id_.Add("emil");
        }
        public bool ValidateEntryRequest(string id)
        {
            foreach (string element in id_)
            {
               bool found= element.Equals(id);

               if (found == true)
               {
                   return true;
               }

            }
            return false;
        }

        private List<string> id_;
    }

}
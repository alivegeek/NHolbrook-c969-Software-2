using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook_c969_Software_2
{
    class User
    {
        public int UUID;
        public string Username;
        public string Password;
        public bool Active;
        public DateTime CreatedOn;
        public DateTime LastUpdate;
        public string CreatedBy;
        public string LastUpdatedBy;

        public User(int uuid, string userName, string password, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UUID = uuid;
            Username = userName;
            Password = password;
            Active = (bool)true;
            CreatedOn = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdateBy;
        }
    }
}

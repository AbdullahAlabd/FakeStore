using FakeStore.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // TODO: Encrypt with a salt
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MSISDN { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGobal.Business.Domain.Entities.Membership
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

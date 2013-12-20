using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity = ExploreGobal.Business.Domain.Entities.Membership;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ExploreGlobal.Infrastructure.Data.Context
{
    public class AccountDbContext : IdentityDbContext<Entity.UserProfile>
    {
        public AccountDbContext()
            : base("DefaultConnection")
        {
        }
    }
}

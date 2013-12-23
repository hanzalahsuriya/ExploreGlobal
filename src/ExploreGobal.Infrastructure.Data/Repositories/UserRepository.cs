using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreGobal.Business.Domain.Interfaces;
using ExploreGobal.Business.Domain.Entities;
using ExploreGlobal.Infrastructure.Data.Context;
using ExploreGobal.Business.Domain.Entities.Membership;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ExploreGlobal.Infrastructure.Data.Repositories
{
    class UserRepository : IUserRepository 
    {
        public AccountDbContext context = new AccountDbContext();

        private UserManager<UserProfile> _userManager;

        /*public System.Linq.IQueryable<UserProfile> UserProfiles
        {
            get
            {
                return context.Users;
            }
        }*/

        public UserManager<UserProfile> UserManager 
        {
            get 
            {
                _userManager = new UserManager<UserProfile>(new UserStore<UserProfile>(new AccountDbContext()));
                return _userManager;
            }
            set 
            {
                _userManager = value;
            }
        }

    }
}

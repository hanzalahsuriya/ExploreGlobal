﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreGobal.Business.Domain.Interfaces;
using ExploreGobal.Business.Domain.Entities;
using ExploreGlobal.Infrastructure.Data.Context;
using ExploreGobal.Business.Domain.Entities.Membership;

namespace ExploreGlobal.Infrastructure.Data.Repositories
{
    class UserRepository : IUserRepository 
    {
        public AccountDbContext context = new AccountDbContext();

        public System.Linq.IQueryable<UserProfile> UserProfiles
        {
            get
            {
                return context.Users;
            }
        }

    }
}
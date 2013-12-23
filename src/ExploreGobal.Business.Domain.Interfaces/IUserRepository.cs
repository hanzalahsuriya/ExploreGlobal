using ExploreGobal.Business.Domain.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;


namespace ExploreGobal.Business.Domain.Interfaces
{
    public interface IUserRepository
    {
        //IQueryable<UserProfile> Users;

        UserManager<UserProfile> UserManager { get; set; }
    }
}

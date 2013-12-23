using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace ExploreGobal.Business.Domain.Entities.Membership
{
    public class UserProfile : IdentityUser, IUser 
    {

    }
}

using ExploreLuxury.Business.Domain.Entities.Membership;
using ExploreLuxury.Business.Domain.Interfaces;
using ExploreLuxury.Infrastructure.Data.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ExploreLuxury.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository 
    {
        public AppDbContext Context = new AppDbContext();

        private UserManager<UserProfile> _userManager;

        public UserManager<UserProfile> UserManager 
        {
            get 
            {
                _userManager = new UserManager<UserProfile>(new UserStore<UserProfile>(new AppDbContext()));
                return _userManager;
            }
            set 
            {
                _userManager = value;
            }
        }

    }
}

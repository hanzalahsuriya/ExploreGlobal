using ExploreLuxury.Business.Domain.Entities.Membership;
using Microsoft.AspNet.Identity;

namespace ExploreLuxury.Business.Domain.Interfaces
{
    public interface IUserRepository
    {
        //IQueryable<UserProfile> Users;

        UserManager<UserProfile> UserManager { get; set; }
    }
}

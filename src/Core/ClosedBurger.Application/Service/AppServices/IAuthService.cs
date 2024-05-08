using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.AppEntities.Identity;

namespace ClosedBurger.Application.Service.AppServices
{
    public interface IAuthService
    {
        Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<AppUser> ChangePasswordAsync(AppUser user, string currentPassword, string newPassword);
        Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId);
        Task<string> GetMainRolesByUserId(string userId);
    }
}

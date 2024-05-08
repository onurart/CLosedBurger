using ClosedBurger.Domain.AppEntities.Identity;
using ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Domain.Repositories.AppDbContext.UserRoleRepositories
{
    public interface IUserRoleQueryRepository : IAppQueryRepository<AppUserRole>
    {
    }
}

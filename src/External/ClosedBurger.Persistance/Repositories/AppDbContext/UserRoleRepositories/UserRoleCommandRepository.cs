using ClosedBurger.Domain.AppEntities.Identity;
using ClosedBurger.Domain.Repositories.AppDbContext.UserRoleRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Persistance.Repositories.AppDbContext.UserRoleRepositories
{
    public sealed class UserRoleCommandRepository : AppCommandRepository<AppUserRole>, IUserRoleCommandRepository
    {
        public UserRoleCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

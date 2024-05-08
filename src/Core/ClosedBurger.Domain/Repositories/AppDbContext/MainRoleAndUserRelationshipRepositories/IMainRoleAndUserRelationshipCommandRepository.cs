using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories
{
    public interface IMainRoleAndUserRelationshipCommandRepository : IAppCommandRepository<MainRoleAndUserRelationship>
    {
    }
}

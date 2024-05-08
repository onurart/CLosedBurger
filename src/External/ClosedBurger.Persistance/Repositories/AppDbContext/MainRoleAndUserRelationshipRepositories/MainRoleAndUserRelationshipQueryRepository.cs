using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories
{
    public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
    {
        public MainRoleAndUserRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
    }
}

using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public interface IUserAndCompanyRelationshipCommandRepository : IAppCommandRepository<UserAndCompanyRelationship>
    {
    }
}

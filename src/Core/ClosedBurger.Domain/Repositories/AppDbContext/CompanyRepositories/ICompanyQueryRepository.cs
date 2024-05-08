using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyQueryRepository : IAppQueryRepository<Company>
    {
    }
}

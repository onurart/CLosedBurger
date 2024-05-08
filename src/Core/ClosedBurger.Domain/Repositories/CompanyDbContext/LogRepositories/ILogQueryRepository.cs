using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext;
namespace ClosedBurger.Domain.Repositories.CompanyDbContext.LogRepositories
{
    public interface ILogQueryRepository : ICompanyDbQueryRepository<Logs>
    {
    }
}

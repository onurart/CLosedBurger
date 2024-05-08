using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.CompanyDbContext.LogRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.CompanyDbContext;

namespace ClosedBurger.Persistance.Repositories.CompanyDbContext.LogRepositories
{
    public class LogCommandRepository : CompanyDbCommandRepository<Logs>, ILogCommandRepository
    {
    }
}

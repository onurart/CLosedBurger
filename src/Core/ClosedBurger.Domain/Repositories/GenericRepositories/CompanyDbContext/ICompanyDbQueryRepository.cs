using ClosedBurger.Domain.Abstraction;

namespace ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>, IQueryGenericRepository<T>where T : Entity
    {
    }
}

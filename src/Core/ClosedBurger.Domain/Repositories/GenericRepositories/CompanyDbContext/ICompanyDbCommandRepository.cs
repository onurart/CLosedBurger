using ClosedBurger.Domain.Abstraction;

namespace ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbCommandRepository<T> : ICompanyDbRepository<T>, ICommandGenericRepository<T> where T :Entity
    {
    }
}

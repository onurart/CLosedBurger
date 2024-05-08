using ClosedBurger.Domain.Abstraction;

namespace ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext
{
    public interface IAppCommandRepository<T> : ICommandGenericRepository<T>, IRepository<T> where T :Entity
    {
    }
}

using ClosedBurger.Domain.Abstraction;
namespace ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext
{
    public interface IAppQueryRepository<T> : IQueryGenericRepository<T>, IRepository<T> where T : Entity
    {
    }
}

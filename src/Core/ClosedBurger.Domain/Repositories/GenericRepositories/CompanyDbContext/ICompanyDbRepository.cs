using ClosedBurger.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbRepository<T> : IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext context);
    }
}

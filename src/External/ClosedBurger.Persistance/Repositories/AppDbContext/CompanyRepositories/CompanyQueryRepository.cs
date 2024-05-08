using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.AppDbContext.CompanyRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.AppDbContext;
namespace ClosedBurger.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public sealed class CompanyQueryRepository : AppQueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}

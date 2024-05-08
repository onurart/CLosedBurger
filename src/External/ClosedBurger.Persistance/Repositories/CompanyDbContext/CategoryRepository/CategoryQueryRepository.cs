using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.CompanyDbContext.CategoryRepository;
using ClosedBurger.Persistance.Repositories.GenericRepositories.CompanyDbContext;

namespace ClosedBurger.Persistance.Repositories.CompanyDbContext.CategoryRepository
{
    public sealed class CategoryQueryRepository : CompanyDbQueryRepository<Category>, ICategoryQueryRepository
    {
    }
}

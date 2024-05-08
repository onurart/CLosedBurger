using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace ClosedBurger.Domain.Repositories.CompanyDbContext.ProductRepositories
{
    public interface IProductCommandRepository : ICompanyDbCommandRepository<Product>
    {
    }
}

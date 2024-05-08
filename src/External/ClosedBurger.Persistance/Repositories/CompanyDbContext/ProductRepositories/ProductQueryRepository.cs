using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.CompanyDbContext.ProductRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Persistance.Repositories.CompanyDbContext.ProductRepositories
{
    public sealed class ProductQueryRepository : CompanyDbQueryRepository<Product>, IProductQueryRepository
    {
    }
}

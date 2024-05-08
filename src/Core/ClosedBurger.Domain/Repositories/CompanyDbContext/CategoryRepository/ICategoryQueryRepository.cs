﻿using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace ClosedBurger.Domain.Repositories.CompanyDbContext.CategoryRepository
{
    public interface ICategoryQueryRepository : ICompanyDbQueryRepository<Category>
    {
    }
}

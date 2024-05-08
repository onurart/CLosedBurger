using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ClosedBurger.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyCommandRepository: IAppCommandRepository<Company>
    {
    }
}

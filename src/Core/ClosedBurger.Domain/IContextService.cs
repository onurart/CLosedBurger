using Microsoft.EntityFrameworkCore;
namespace ClosedBurger.Domain;
public interface IContextService
{
    DbContext CreateDbContextInstance(string companyId);
}

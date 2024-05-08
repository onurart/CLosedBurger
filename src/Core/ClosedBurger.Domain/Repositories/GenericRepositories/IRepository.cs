using Microsoft.EntityFrameworkCore;
using ClosedBurger.Domain.Abstraction;
namespace ClosedBurger.Domain.Repositories.GenericRepositories;
public interface IRepository<T> where T : Entity
{
    DbSet<T> Entity { get; set; }
}
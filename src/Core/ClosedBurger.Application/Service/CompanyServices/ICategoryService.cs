using ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
using ClosedBurger.Domain.CompanyEntities;
namespace ClosedBurger.Application.Service.CompanyServices
{
    public interface ICategoryService
    {
        Task<Category> CreateCategoryAsync(CreateCategoryCommand request, CancellationToken cancellationToken);
        Task<IList<Category>> GetAllCategoryAsync(string companyId);
    }
}

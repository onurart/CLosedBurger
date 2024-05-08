using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Dtos;
using EntityFrameworkCorePagination.Nuget.Pagination;
namespace ClosedBurger.Application.Service.CompanyServices
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(CreateProductCommand requst, CancellationToken cancellationToken);
        Task<IList<Product>> GetAllAsync(GetAllProductQuery request);
        Task UpdateAsync(Product product, string companyId);
    }
}

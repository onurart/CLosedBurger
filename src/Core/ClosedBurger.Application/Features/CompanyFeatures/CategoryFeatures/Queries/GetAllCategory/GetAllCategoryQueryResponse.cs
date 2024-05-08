using ClosedBurger.Domain.CompanyEntities;
namespace ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Queries.GetAllCategory;
public sealed record GetAllCategoryQueryResponse(IList<Category> Data);

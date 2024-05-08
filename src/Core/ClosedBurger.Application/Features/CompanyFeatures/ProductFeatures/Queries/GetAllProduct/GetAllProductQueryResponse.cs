using ClosedBurger.Domain.CompanyEntities;

namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
public sealed record GetAllProductQueryResponse(IList<Product> Data);

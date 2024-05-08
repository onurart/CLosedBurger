using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Dtos;

namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
public sealed record GetAllProductQueryResponse(IList<ProductListDto> Data);
//public sealed record GetAllProductQueryResponse(IList<Product> Data);

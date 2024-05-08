using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
public sealed record GetAllProductQuery(string CompanyId) : IQuery<GetAllProductQueryResponse>;


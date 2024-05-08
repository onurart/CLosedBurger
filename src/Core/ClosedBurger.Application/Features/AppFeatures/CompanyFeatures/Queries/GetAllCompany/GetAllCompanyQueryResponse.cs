using ClosedBurger.Domain.AppEntities;
namespace ClosedBurger.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQueryResponse(List<Company> Companies);
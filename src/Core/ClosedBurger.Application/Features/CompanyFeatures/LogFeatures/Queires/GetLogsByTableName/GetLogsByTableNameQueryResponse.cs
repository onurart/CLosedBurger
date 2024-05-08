using EntityFrameworkCorePagination.Nuget.Pagination;
using ClosedBurger.Domain.Dtos;
namespace ClosedBurger.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName;
public sealed record GetLogsByTableNameQueryResponse(PaginationResult<LogDto> Data);

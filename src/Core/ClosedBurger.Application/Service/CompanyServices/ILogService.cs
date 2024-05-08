using ClosedBurger.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName;
using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Dtos;
using EntityFrameworkCorePagination.Nuget.Pagination;

namespace ClosedBurger.Application.Service.CompanyServices
{
    public interface ILogService
    {
        Task AddAsync(Logs log, string companyId);
        Task<PaginationResult<LogDto>> GetAllByTableName(GetLogsByTableNameQuery request);
    }
}

using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Dtos;
using EntityFrameworkCorePagination.Nuget.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Service.CompanyServices
{
    public interface ILogService
    {
        Task AddAsync(Logs log, string companyId);
      //  Task<PaginationResult<LogDto>> GetAllByTableName(GetLogsByTableNameQuery request);
    }
}

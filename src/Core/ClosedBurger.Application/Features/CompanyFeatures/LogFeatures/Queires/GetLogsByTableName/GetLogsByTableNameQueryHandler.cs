using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service.CompanyServices;
namespace ClosedBurger.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName
{
    public sealed class GetLogsByTableNameQueryHandler : IQueryHandler<GetLogsByTableNameQuery, GetLogsByTableNameQueryResponse>
    {
        private readonly ILogService _logService;

        public GetLogsByTableNameQueryHandler(ILogService logService)
        {
            _logService = logService;
        }
        public async Task<GetLogsByTableNameQueryResponse> Handle(GetLogsByTableNameQuery request, CancellationToken cancellationToken)
        {
            return new(await _logService.GetAllByTableName(request));
        }
    }
}

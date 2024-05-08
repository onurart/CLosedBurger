using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service.CompanyServices;
namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct
{
    public sealed class GetAllProductQueryHandler : IQueryHandler<GetAllProductQuery, GetAllProductQueryResponse>
    {
        private readonly IProductService _service;

        public GetAllProductQueryHandler(IProductService service)
        {
            _service = service;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return new(await _service.GetAllAsync(request));
        }

    }
    }

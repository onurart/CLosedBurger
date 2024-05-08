using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service;
using ClosedBurger.Application.Service.CompanyServices;
using ClosedBurger.Domain.CompanyEntities;
using Newtonsoft.Json;

namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct
{
    public sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        private readonly IProductService _productService;
        private readonly ILogService _logService;
        private readonly IApiService _apiService;

        public CreateProductCommandHandler(IProductService productService, ILogService logService, IApiService apiService)
        {
            _productService = productService;
            _logService = logService;
            _apiService = apiService;
        }
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product newProduct = await _productService.CreateProductAsync(request, cancellationToken);
            var userId = _apiService.GetUserByIdTokem(); ;
            Logs log = new()
            {
                Id = Guid.NewGuid().ToString(),
                TableName = nameof(Product),
                Progress = "Create",
                UserId = userId,
                Data = JsonConvert.SerializeObject(newProduct)
            };
            await _logService.AddAsync(log, request.CompanyId);
            return new();
        }
    }
}

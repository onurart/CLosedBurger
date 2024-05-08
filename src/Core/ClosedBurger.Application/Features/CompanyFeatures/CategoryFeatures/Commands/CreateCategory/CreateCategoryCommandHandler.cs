using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service;
using ClosedBurger.Application.Service.CompanyServices;
using ClosedBurger.Domain.CompanyEntities;
using Newtonsoft.Json;
namespace ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
public sealed class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, CreateCategoryResponse>
{
    private readonly ICategoryService _categoryService;
    private readonly IApiService _apiService;
    private readonly ILogService _logService;
    public CreateCategoryCommandHandler(ICategoryService categoryService, IApiService apiService, ILogService logService)
    {
        _categoryService = categoryService;
        _apiService = apiService;
        _logService = logService;
    }
    public async Task<CreateCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        Category createCategory = await _categoryService.CreateCategoryAsync(request, cancellationToken);
        string userId = _apiService.GetUserByIdTokem();
        Logs log = new Logs()
        {
            Id = Guid.NewGuid().ToString(),
            TableName = nameof(Category),
            Progress = "Create Category",
            UserId = userId,
            Data = JsonConvert.SerializeObject(createCategory)
        };
        await _logService.AddAsync(log, request.CompanyId);
        return new();
    }
}

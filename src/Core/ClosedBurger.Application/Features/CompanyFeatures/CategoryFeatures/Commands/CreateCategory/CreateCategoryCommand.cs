using ClosedBurger.Application.Messaging;

namespace ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
public sealed record  CreateCategoryCommand
                                                (string Name, string CompanyId) : ICommand<CreateCategoryResponse>;

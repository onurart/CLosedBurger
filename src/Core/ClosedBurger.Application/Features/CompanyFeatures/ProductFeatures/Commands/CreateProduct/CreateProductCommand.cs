using ClosedBurger.Application.Messaging;

namespace ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
public sealed record class CreateProductCommand
                                        (
                                        string? ProductName,
                                        string? ProductCode,
                                        string? Description,
                                        decimal? Price,
                                        string? CategoryId,
                                        string? CompanyId) : ICommand<CreateProductCommandResponse>;


using ClosedBurger.Domain.Dtos;

namespace ClosedBurger.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(TokenRefreshTokenDto Token, string Email, string UserId, string NameLastName, string MainRole, IList<CompanyDto?>? Companies, CompanyDto? Company);

}

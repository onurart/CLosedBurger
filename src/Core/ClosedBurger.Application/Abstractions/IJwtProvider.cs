using ClosedBurger.Domain.AppEntities.Identity;
using ClosedBurger.Domain.Dtos;
namespace ClosedBurger.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);
    }
}

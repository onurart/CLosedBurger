using ClosedBurger.Application.Abstractions;
using ClosedBurger.Domain.AppEntities.Identity;
using ClosedBurger.Domain.Dtos;
using Microsoft.AspNetCore.Identity;
namespace ClosedBurger.Infrasturcture.Authentication
{
    internal class JwtProvider : IJwtProvider
    {
        private readonly JwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;
        
        
        public Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}

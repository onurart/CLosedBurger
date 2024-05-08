using ClosedBurger.Application.Service;
using Microsoft.AspNetCore.Http;
namespace ClosedBurger.Infrasturcture.Services
{
    public sealed class ApiService : IApiService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApiService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetUserByIdTokem()
        {
           var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p=>p.Type.Contains("authentication"))?.Value;
            return userId ?? string.Empty;
        }
    }
}

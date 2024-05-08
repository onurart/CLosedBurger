using ClosedBurger.Application.Abstractions;
using ClosedBurger.Application.Services;
using ClosedBurger.Infrasturcture.Services;
using ClosedBurger.Infrasturcture.Authentication;
using ClosedBurger.WebApi.Configurations;
using ClosedBurger.Application.Service;

namespace ClosedBurger.WebApi.Configurations
{
    public class InfrustructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IJwtProvider, JwtProvider>();
            services.AddScoped<IApiService, ApiService>();
        }
    }
}

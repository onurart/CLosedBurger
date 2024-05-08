using Microsoft.AspNetCore.Authentication.JwtBearer;
using ClosedBurger.WebApi.OptionsSetup;

namespace ClosedBurger.WebApi.Configurations
{
    public class AuthenticationAndAuthorizationSeviceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionsSetup>();
            services.ConfigureOptions<JwtBearerOptionsSetup>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
            services.AddAuthorization();
        }
    }
}

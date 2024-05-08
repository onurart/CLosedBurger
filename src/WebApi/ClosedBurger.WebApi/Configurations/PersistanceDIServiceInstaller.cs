using ClosedBurger.Application.Service.AppServices;
using ClosedBurger.Application.Service.CompanyServices;
using ClosedBurger.Application.Services.AppServices;
using ClosedBurger.Domain;
using ClosedBurger.Domain.Repositories.AppDbContext.CompanyRepositories;
using ClosedBurger.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ClosedBurger.Domain.Repositories.AppDbContext.MainRoleReporistories;
using ClosedBurger.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using ClosedBurger.Domain.Repositories.AppDbContext.UserRoleRepositories;
using ClosedBurger.Domain.Repositories.CompanyDbContext.CategoryRepository;
using ClosedBurger.Domain.Repositories.CompanyDbContext.LogRepositories;
using ClosedBurger.Domain.Repositories.CompanyDbContext.ProductRepositories;
using ClosedBurger.Domain.UnitOfWorks;
using ClosedBurger.Persistance;
using ClosedBurger.Persistance.Repositories.AppDbContext.CompanyRepositories;
using ClosedBurger.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ClosedBurger.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using ClosedBurger.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipCommandRepository;
using ClosedBurger.Persistance.Repositories.AppDbContext.UserRoleRepositories;
using ClosedBurger.Persistance.Repositories.CompanyDbContext.CategoryRepository;
using ClosedBurger.Persistance.Repositories.CompanyDbContext.LogRepositories;
using ClosedBurger.Persistance.Repositories.CompanyDbContext.ProductRepositories;
using ClosedBurger.Persistance.Services.AppServices;
using ClosedBurger.Persistance.Services.CompanyServices;
using ClosedBurger.Persistance.UnitOfWorks;
using ClosedBurger.WebApi.Configurations;

namespace ClosedBurger.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            #region CompanyDbContext
            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
      

            #endregion

            #region AppDbContext
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMainRoleService, MainRoleService>();
            services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
            services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            #endregion
            #endregion

            #region Repositories
            #region CompanyDbContext
            services.AddScoped<ILogCommandRepository, LogCommandRepository>();
            services.AddScoped<ILogQueryRepository, LogQueryRepository>();
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            
            services.AddScoped<ICategoryCommandRepository, CategoryCommandRepository>();
            services.AddScoped<ICategoryQueryRepository, CategoryQueryRepository>();




            services.AddHttpClient();

            #endregion


            #region AppDbContext
            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
            services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
            services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
            services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
            services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
            services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();
            services.AddScoped<IUserRoleCommandRepository, UserRoleCommandRepository>();
            services.AddScoped<IUserRoleQueryRepository, UserRoleQueryRepository>();
            #endregion
            #endregion
        }
    }
}

using AutoMapper;
using ClosedBurger.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.CompanyEntities;
namespace ClosedBurger.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<CreateCompanyCommand, Company>();

        }
    }
}

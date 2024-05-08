using AutoMapper;
using ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
using ClosedBurger.Domain.CompanyEntities;
namespace ClosedBurger.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<CreateProductCommand, Product>();
        }
    }
}

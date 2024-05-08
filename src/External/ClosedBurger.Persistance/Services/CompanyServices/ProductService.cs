using AutoMapper;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
using ClosedBurger.Application.Service.CompanyServices;
using ClosedBurger.Domain;
using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Domain.Dtos;
using ClosedBurger.Domain.Repositories.CompanyDbContext.ProductRepositories;
using ClosedBurger.Domain.UnitOfWorks;
using ClosedBurger.Persistance.Context;
using EntityFrameworkCorePagination.Nuget.Pagination;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Persistance.Services.CompanyServices
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductCommandRepository _commandRepository;
        private readonly IProductQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _companyDbUnitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public ProductService(IProductCommandRepository commandRepository, IProductQueryRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork companyDbUnitOfWork, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _contextService = contextService;
            _companyDbUnitOfWork = companyDbUnitOfWork;
            _mapper = mapper;
        }

        public async Task<Product> CreateProductAsync(CreateProductCommand requst, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(requst.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _companyDbUnitOfWork.SetDbContextInstance(_context);
            Product product = _mapper.Map<Product>(requst);
            product.Id = Guid.NewGuid().ToString();
            await _commandRepository.AddAsync(product, cancellationToken);
            await _companyDbUnitOfWork.SaveChangesAsync(cancellationToken);
            return product;
        }

        //public async Task<IList<Product>> GetAllAsync(GetAllProductQuery request)
        //{
        //    _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
        //    _queryRepository.SetDbContextInstance(_context);
        //    return await _queryRepository.GetAll().AsNoTracking().ToListAsync();
        //}

        public async Task<IList<ProductListDto>> GetAllAsync(GetAllProductQuery request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _queryRepository.SetDbContextInstance(_context);

            //var prodcustrel = await _queryRepository.GetAll().Include("Product").ToListAsync();
            var product = await _queryRepository.GetAll().Include("Category").ToListAsync();
            var prodcustrel = await _queryRepository.GetAll() .Include(p => p.Category) // Include methodunu Category ilişki yoluna güncelledik
    .ToListAsync();
            var joinedData = (from pc in prodcustrel
                              join p in product on pc.Id equals p.Id
                              orderby pc.CreatedDate descending
                              select new ProductListDto
                              {
                                  Id = pc.Id,
                                  ProductName = p.ProductName,
                                  ProductCode = p.ProductCode,
                                  Description = p.Description,
                                  Price= p.Price,
                                  CategoryId = p.CategoryId,
                                  CategoryName = p.Category.Name,
                              }).ToList();

            IList<ProductListDto> list = new List<ProductListDto>();
            foreach (var item in joinedData)
            {
                list.Add(new ProductListDto()
                {
                    Id = item.Id,
                    ProductName = item.ProductName,
                    ProductCode = item.ProductCode,
                    Description = item.Description,
                    Price = item.Price,
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName,

                });
            }

            // Burada dönüş yapmanız gerekiyor
            return list;
        }



        public async Task UpdateAsync(Product product, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            _companyDbUnitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(product);
            await _companyDbUnitOfWork.SaveChangesAsync();
        }
    }
}

using ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Commands.CreateCategory;
using ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Queries.GetAllCategory;
using ClosedBurger.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ClosedBurger.Presentation.Controller
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CategoryController : ApiController
    {
        public CategoryController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand requst, CancellationToken cancellationToken)
        {
            CreateCategoryResponse response= await _mediator.Send(requst, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]/{companyid}")]
        public async Task<IActionResult> GetAllCategory(string companyid)
        {
            GetAllCategoryQuery request = new(companyid);
            GetAllCategoryQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

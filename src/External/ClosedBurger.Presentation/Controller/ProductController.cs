﻿using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Commands.CreateProduct;
using ClosedBurger.Application.Features.CompanyFeatures.ProductFeatures.Queries.GetAllProduct;
using ClosedBurger.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ClosedBurger.Presentation.Controller
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ProductController : ApiController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request, CancellationToken cancellationToken)
        {
            CreateProductCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllProduct(GetAllProductQuery request)
        {
            GetAllProductQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
       
            
    }
}

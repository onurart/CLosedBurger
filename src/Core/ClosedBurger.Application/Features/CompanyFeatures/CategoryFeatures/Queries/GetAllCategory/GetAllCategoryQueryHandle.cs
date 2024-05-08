﻿using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service.CompanyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Queries.GetAllCategory
{
    public sealed class GetAllCategoryQueryHandle : IQueryHandler<GetAllCategoryQuery, GetAllCategoryQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetAllCategoryQueryHandle(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return new(await _categoryService.GetAllCategoryAsync(request.CompanyId));
        }
    }
}

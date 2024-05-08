﻿using ClosedBurger.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Features.CompanyFeatures.CategoryFeatures.Queries.GetAllCategory
{
    public sealed record GetAllCategoryQuery(string? CompanyId) : IQuery<GetAllCategoryQueryResponse>;

}

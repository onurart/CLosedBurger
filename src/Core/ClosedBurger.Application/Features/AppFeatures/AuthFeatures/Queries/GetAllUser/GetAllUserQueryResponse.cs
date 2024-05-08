﻿using ClosedBurger.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Features.AppFeatures.AuthFeatures.Queries.GetAllUser
{
    public sealed record GetAllUserQueryResponse(List<UsersDto> Users);
}

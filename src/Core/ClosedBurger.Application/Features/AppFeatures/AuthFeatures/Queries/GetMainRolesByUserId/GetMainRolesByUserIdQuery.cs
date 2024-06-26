﻿using ClosedBurger.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Features.AppFeatures.AuthFeatures.Queries.GetMainRolesByUserId
{
    public sealed record GetMainRolesByUserIdQuery(string UserId) : IQuery<GetMainRolesByUserIdQueryResponse>;
}

﻿using ClosedBurger.Domain.AppEntities;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Queries;
public sealed record GetAllMainRoleAndUserQueryResponse(List<MainRoleAndUserRelationship> mainRoleAndUserRelationships)
{
}
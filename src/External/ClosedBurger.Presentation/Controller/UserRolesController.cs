﻿using ClosedBurger.Presentation.Abstraction;
using ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Commands.CreateUserRole;
using ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetAllUserRoles;
using ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ClosedBurger.Presentation.Controller;
[Authorize(AuthenticationSchemes = "Bearer")]

public class UserRolesController : ApiController
{
    public UserRolesController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        CreateUserRoleCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> GetAllUserRoles(GetAllUserRolesQuery request)
    {
        GetAllUserRolesQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> GetByUserIdRoles(GetUserRolesQuery request)
    {
        GetUserRolesQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
﻿using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;
public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;
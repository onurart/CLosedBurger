﻿using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;
public sealed record CreateMainRoleAndUserRLCommand(string UserId, string MainRoleId) : ICommand<CreateMainRoleAndUserRLCommandResponse>;
﻿using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
public sealed record CreateUserAndCompanyRLCommand(string AppUserId, string CompanyId) : ICommand<CreateUserAndCompanyRLCommandResponse>;
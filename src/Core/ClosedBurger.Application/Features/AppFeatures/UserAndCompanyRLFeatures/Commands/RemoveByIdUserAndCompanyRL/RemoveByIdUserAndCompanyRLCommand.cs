﻿using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;
public sealed record RemoveByIdUserAndCompanyRLCommand(string Id) : ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;
﻿using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
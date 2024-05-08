using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Service;
using ClosedBurger.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUserName, string Password) : ICommand<Result<LoginCommandResponse>>;
}

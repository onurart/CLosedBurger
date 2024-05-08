using ClosedBurger.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
public sealed record CreateMainRoleCommand(string Title) : ICommand<CreateMainRoleCommandResponse>;
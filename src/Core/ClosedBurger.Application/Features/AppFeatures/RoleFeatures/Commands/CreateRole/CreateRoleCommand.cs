using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
public sealed record CreateRoleCommand(string Code, string Name) : ICommand<CreateRoleCommandResponse>;
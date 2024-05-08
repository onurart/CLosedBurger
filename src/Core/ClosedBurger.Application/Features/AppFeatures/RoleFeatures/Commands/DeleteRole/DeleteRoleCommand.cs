using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;
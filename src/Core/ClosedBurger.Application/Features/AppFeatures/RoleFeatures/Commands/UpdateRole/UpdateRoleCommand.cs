using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
public sealed record UpdateRoleCommand(string Id, string Code, string Name) : ICommand<UpdateRoleCommandResponse>;
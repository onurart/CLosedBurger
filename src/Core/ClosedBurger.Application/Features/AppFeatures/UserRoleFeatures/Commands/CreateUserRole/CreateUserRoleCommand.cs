using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Commands.CreateUserRole;
public sealed record CreateUserRoleCommand(string RoleId, string UserId) : ICommand<CreateUserRoleCommandResponse>;
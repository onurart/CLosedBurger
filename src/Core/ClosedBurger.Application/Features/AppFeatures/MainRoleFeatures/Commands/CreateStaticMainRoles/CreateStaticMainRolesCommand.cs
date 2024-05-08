using ClosedBurger.Application.Messaging;
using ClosedBurger.Domain.AppEntities;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
public sealed record CreateStaticMainRolesCommand(List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>;
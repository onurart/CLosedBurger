using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
public sealed record RemoveByIdMainRoleCommand(string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
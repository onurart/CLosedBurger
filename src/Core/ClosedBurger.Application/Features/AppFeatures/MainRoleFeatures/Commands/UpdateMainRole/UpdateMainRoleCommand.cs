using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
public sealed record UpdateMainRoleCommand(string Id, string Title) : ICommand<UpdateMainRoleCommandResponse>;
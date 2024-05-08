using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
public sealed record GetUserRolesQuery(string UserId) : IQuery<GetUserRolesQueryResponse>;
using ClosedBurger.Application.Messaging;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;
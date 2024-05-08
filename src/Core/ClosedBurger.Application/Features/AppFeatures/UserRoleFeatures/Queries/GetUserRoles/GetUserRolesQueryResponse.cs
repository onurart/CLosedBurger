using ClosedBurger.Domain.AppEntities.Identity;
namespace ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
public sealed record GetUserRolesQueryResponse(IList<AppUserRole> AppUserRoles);
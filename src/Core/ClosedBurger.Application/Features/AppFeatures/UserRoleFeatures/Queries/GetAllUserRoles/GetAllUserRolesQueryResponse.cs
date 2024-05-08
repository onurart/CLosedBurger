using ClosedBurger.Domain.AppEntities.Identity;
namespace ClosedBurger.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetAllUserRoles;
public sealed record GetAllUserRolesQueryResponse(IList<AppUserRole> AppUserRoles);
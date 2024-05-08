using ClosedBurger.Domain.AppEntities.Identity;
namespace ClosedBurger.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed record GetAllRolesQueryResponse(IList<AppRole> Roles);
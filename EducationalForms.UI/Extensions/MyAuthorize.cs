using System.Security.Claims;
using Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EducationalForms.UI.Extensions;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class MyAuthorize : AuthorizeAttribute, IAsyncAuthorizationFilter
{
    private readonly RoleTypeEnum[] allowedRoles;

    public MyAuthorize(params RoleTypeEnum[] roles)
    {
        allowedRoles = roles;
    }

    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        if (context == null) return;
        var claimsIdentity = (ClaimsIdentity)context.HttpContext.User.Identity;
        var claim = claimsIdentity?.FindFirst(System.Security.Claims.ClaimTypes.Role);
        var userRoles = claim?.Value.Split(",");

        var allowed = allowedRoles.Any(allowedRole => userRoles != null && userRoles.Contains(allowedRole.ToString()));
        if (!allowed)
        {
            context.HttpContext.Response.Redirect("/index");
        }
        else
        {
            return;
        }

        return;
    }
}
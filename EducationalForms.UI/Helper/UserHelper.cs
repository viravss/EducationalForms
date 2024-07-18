using System.Security.Claims;
using Domain.Enums;

namespace EducationalForms.UI.Helper;

public static class UserHelper
{
    public static (string? mobilePhone, int consultantId, string? fullName, string? role) GetCurrentUser(
        HttpContext httpContextAccessor)
    {
        //LoginedUserViewModel item = new LoginedUserViewModel();
        if (httpContextAccessor.User.Identity is not { IsAuthenticated: true }) return ("", 0, "", null);


        var claimsIdentity = (ClaimsIdentity)httpContextAccessor.User.Identity;
        var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
        var consultantId = Convert.ToInt32(claim.Value);

        var claimUserName = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.Name);

        //var userId = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var mobilePhone = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.MobilePhone)?.Value;
        var fullName = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.Name)?.Value;
        var role = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.Role)?.Value;

        return (mobilePhone, consultantId, fullName, role);
    }
}
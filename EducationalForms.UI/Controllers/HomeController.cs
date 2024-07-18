using System.Security.Claims;
using Application.UnitOfWork;
using EducationalForms.UI.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Polly;

namespace EducationalForms.UI.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[MyAuthorize("admin")]
        [Route("/")]
        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
            }
            else
            {
            }

            return View();
        }

        [Route("/")]
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            // await _authenticationService.SignIn(user);
            var user = await _unitOfWork.User.GetUserByUsernameAndPassword(username, password);
            if (user != null)
            {
                var properties = new AuthenticationProperties
                {
                    AllowRefresh = false,
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1)
                };
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.ConsultantId.ToString()),
                    new Claim(ClaimTypes.MobilePhone, user.CellPhone?.ToString() ?? ""),
                    new Claim(ClaimTypes.Name, $"{user.Consultant.Name} {user.Consultant.Family}"),
                    new Claim(ClaimTypes.Role, user.RoleType.ToString())
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal, properties);
            }
            else
            {
                ViewBag.Message = "usernamr or password is incorrect!";
            }


            return View();
        }
    }
}
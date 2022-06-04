using Application.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            var failureReasons = _unitOfWork.FailureReason
                .GetAll(r => r.IsActive)
                .ToList();
            return View();
        }
    }
}
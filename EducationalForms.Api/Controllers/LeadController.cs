using System.Runtime.CompilerServices;
using Application.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EducationalForms.Api.Controllers
{
    public class LeadController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LeadController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

using Application.UnitOfWork;
using Domain.Enums;
using Domain.Models;
using EducationalForms.UI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace EducationalForms.UI.Controllers
{
    [Route("[Controller]/{Action}")]
    public class LeadController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeadController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("lead")]
        // GET: LeadController
        public IActionResult Index()
        {
            var lead = _unitOfWork.Lead.GetAll(t => t.Id != null)
                 .Include(t => t.FamiliarityMethod)
                 .Include(t => t.Consultant)
                 .ToList();
            var leadDto = lead.Select(t => new LeadDto
            {
                Gender = t.Gender,
                Name = t.Name,
                CalledOn = t.CreateOn,
                CellPhone = t.CellPhone,
                Consultant = new ConsultantDto
                {
                    Family = t.Consultant?.Family,
                    Name = t.Consultant?.Name,
                    Id = t.Id
                },
                Family = t.Family,
                Id = t.Id,
                FamiliarityMethod = new FamiliarityMethodDto
                {
                    Name = t.FamiliarityMethod?.Name,
                    Id = t.FamiliarityMethod.Id,
                },
                PhoneNumber = t.PhoneNumber
            }).ToList();
            return View(leadDto);
        }
        // GET: LeadController/Create
        public IActionResult Create()
        {
            var familiarityMethods = _unitOfWork.FamiliarityMethod
                .GetAll(t => t.IsActive);
            ViewBag.FamiliarityMethod =
                familiarityMethods
                    .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                    .ToList();


            var failureReasons = _unitOfWork.FailureReason
                .GetAll(t => t.IsActive);
            ViewBag.FailureReason =
                failureReasons
                    .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                    .ToList();


            var consultants = _unitOfWork.Consultant
                .GetAll(t => t.IsActive);
            ViewBag.Consultants =
                consultants
                    .Select(t => new SelectListItem { Text = t.Name + " " + t.Family, Value = t.Id.ToString() })
                    .ToList();

            var skills = _unitOfWork.Skill
                .GetAll(t => t.Id != null);
            ViewBag.LeadSkills =
                skills
                    .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                    .ToList();


            ViewBag.GenderEnumList = Enum.GetValues(typeof(GenderEnum)).Cast<GenderEnum>()
                .Select(t => new SelectListItem { Text = t.GetDisplayName(), Value = t.GetDisplayName() }).ToList();
            return View();
        }

        // POST: LeadController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeadDto leadDto)
        {
            try
            {

                var lead = await _unitOfWork.Lead.Create(new Lead
                {
                    Gender = leadDto.Gender,
                    //LeadSkills = leadDto.LeadSkillIds.Select(t=> new LeadSkill{ Id = t.Id ,  }),
                    CalledOn = DateTime.Now,
                    CellPhone = leadDto.CellPhone,
                    ConsultantId = leadDto.ConsultantId,
                    Description = leadDto.Description,
                    FailureReasonId = leadDto.FailureReasonId,
                    FamiliarityMethodId = leadDto.FamiliarityMethodId,
                    Family = leadDto.Family,
                    Name = leadDto.Name,
                    PhoneNumber = leadDto.PhoneNumber
                });
                await _unitOfWork.SaveChangesAsync();

                foreach (var skillId in leadDto.LeadSkillIds)
                {
                    await _unitOfWork.LeadSkill.Create(new LeadSkill
                    {
                        LeadId = lead.Entity.Id,
                        SkillId = skillId
                    });
                }
                if (leadDto.LeadSkillIds.Length > 0)
                    await _unitOfWork.SaveChangesAsync();

                var familiarityMethods = _unitOfWork.FamiliarityMethod
                    .GetAll(t => t.IsActive);
                ViewBag.FamiliarityMethod =
                    familiarityMethods
                        .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                        .ToList();


                var failureReasons = _unitOfWork.FailureReason
                    .GetAll(t => t.IsActive);
                ViewBag.FailureReason =
                    failureReasons
                        .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                        .ToList();


                var consultants = _unitOfWork.Consultant
                    .GetAll(t => t.IsActive);
                ViewBag.Consultants =
                    consultants
                        .Select(t => new SelectListItem { Text = t.Name + " " + t.Family, Value = t.Id.ToString() })
                        .ToList();

                var skills = _unitOfWork.Skill
                    .GetAll(t => t.Id != null);
                ViewBag.LeadSkills =
                    skills
                        .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                        .ToList();


                ViewBag.GenderEnumList = Enum.GetValues(typeof(GenderEnum)).Cast<GenderEnum>()
                    .Select(t => new SelectListItem { Text = t.GetDisplayName(), Value = t.GetDisplayName() }).ToList();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeadController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeadController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Application.UnitOfWork;
using Domain.Enums;
using Domain.Models;
using EducationalForms.UI.Dtos;
using EducationalForms.UI.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace EducationalForms.UI.Controllers
{
    [Route("[Controller]/{Action}")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("student")]
        // GET: LeadController
        public IActionResult Index()
        {
            var lead = _unitOfWork.Student.GetAll(t => t.Id != null)
                 .Include(t => t.FamiliarityMethod)
                 .Include(t => t.Consultant)
                 .ToList();
            var leadDto = lead.Select(t => new StudentDto
            {
                Gender = t.Gender,
                Name = t.Name,
                CellPhone = t.CellPhone,
                RegisterTime = t.RegisterTime,
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

        public async Task<IActionResult> Create(int? leadId)
        {
            var lead = new Lead();
            var student = new StudentDto();
            if (leadId is not null)
            {
                lead = await _unitOfWork.Lead.GetFirst(t => t.Id == leadId);
                student = new StudentDto
                {
                    Gender = lead.Gender,
                    Name = lead.Name,
                    CellPhone = lead.CellPhone,
                    ConsultantId = lead.ConsultantId ?? 0,
                    Description = lead.Description,
                    Family = lead.Family,
                    PhoneNumber = lead.PhoneNumber.Split("-").Length > 1 ? lead.PhoneNumber.Split("-")[1].ToString() : "",
                    CityCode = lead.PhoneNumber.Split("-").Length > 1 ? lead.PhoneNumber.Split("-")[0].ToString() : "",
                    StudentSkillIds = lead.LeadSkills.Select(t => t.SkillId).ToArray(),
                };
            }



            var familiarityMethods = _unitOfWork.FamiliarityMethod
                .GetAll(t => t.IsActive);
            ViewBag.FamiliarityMethod =
                familiarityMethods
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



            var services = _unitOfWork.Service
                .GetAll(t => t.Id != null);
            ViewBag.StudentServices =
                services
                    .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                    .ToList();



            ViewBag.GenderEnumList = Enum.GetValues(typeof(GenderEnum)).Cast<GenderEnum>()
                .Select(t => new SelectListItem { Text = t.GetDescription(), Value = t.GetDisplayName() }).ToList();


            ViewBag.MaritalStatusEnums = Enum.GetValues(typeof(MaritalStatusEnum)).Cast<MaritalStatusEnum>()
                .Select(t => new SelectListItem { Text = t.GetDescription(), Value = t.GetDisplayName() }).ToList();

            return View(student);
        }

        // POST: LeadController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentDto studentDto)
        {
            try
            {
                studentDto.BirthDate = studentDto.BirthDateDto.ConvertedDateTime;
                studentDto.RegisterTime = studentDto.CreatedOnDto.ConvertedDateTime;
                var student = await _unitOfWork.Student.Create(new Student
                {
                    Gender = studentDto.Gender,
                    CellPhone = studentDto.CellPhone,
                    ConsultantId = studentDto.ConsultantId,
                    Description = studentDto.Description,
                    FamiliarityMethodId = studentDto.FamiliarityMethodId,
                    Family = studentDto.Family,
                    Name = studentDto.Name,
                    BirthDate = studentDto.BirthDate,
                    Citizen = studentDto.Citizen,
                    FatherName = studentDto.FatherName,
                    IdentityNumber = studentDto.IdentityNumber,
                    MaritalStatus = studentDto.MaritalStatus,
                    NationalCode = studentDto.NationalCode,
                    PhoneNumber = studentDto.PhoneNumber,
                    PhotoAddress = "",
                    PlaceOfIssued = studentDto.PlaceOfIssued,
                    PortalStatus = studentDto.PortalStatus,
                    WhatsAppNumber = studentDto.WhatsAppNumber,
                    RegisterTime = studentDto.RegisterTime
                });
                await _unitOfWork.SaveChangesAsync();

                foreach (var skillId in studentDto.StudentSkillIds)
                {
                    await _unitOfWork.StudentSkill.Create(new StudentSkill
                    {
                        StudentId = student.Entity.Id,
                        SkillId = skillId
                    });
                }

                foreach (var serviceId in studentDto.StudentSkillIds)
                {
                    await _unitOfWork.StudentService.Create(new StudentService
                    {
                        StudentId = student.Entity.Id,
                        ServiceId = serviceId
                    });
                }

                if (studentDto.StudentServiceIds?.Length > 0 || studentDto.StudentSkillIds?.Length > 0)
                    await _unitOfWork.SaveChangesAsync();

                var familiarityMethods = _unitOfWork.FamiliarityMethod
                    .GetAll(t => t.IsActive);
                ViewBag.FamiliarityMethod =
                    familiarityMethods
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



                var services = _unitOfWork.Service
                    .GetAll(t => t.Id != null);
                ViewBag.StudentServices =
                    services
                        .Select(t => new SelectListItem { Text = t.Name, Value = t.Id.ToString() })
                        .ToList();




                ViewBag.GenderEnumList = Enum.GetValues(typeof(GenderEnum)).Cast<GenderEnum>()
                    .Select(t => new SelectListItem { Text = t.GetDescription(), Value = t.GetDisplayName() }).ToList();


                ViewBag.MaritalStatusEnums = Enum.GetValues(typeof(MaritalStatusEnum)).Cast<MaritalStatusEnum>()
                    .Select(t => new SelectListItem { Text = t.GetDescription(), Value = t.GetDisplayName() }).ToList();

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

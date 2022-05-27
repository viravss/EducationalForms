using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class StudentSkillService : CommonIdentityService<StudentSkill>, IStudentSkillService
{
    private readonly IUnitOfWork _unitOfWork;
    public StudentSkillService(ICommonIdentityRepository<StudentSkill> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}
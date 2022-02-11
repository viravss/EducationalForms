using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class SkillService : GenericIdentityService<Skill>, ISkillService
{
    private readonly IUnitOfWork _unitOfWork;
    public SkillService(IGenericIdentityRepository<Skill> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}
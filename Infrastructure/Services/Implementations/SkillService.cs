using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class SkillService : CommonIdentityService<Skill>, ISkillService
{
    private readonly IUnitOfWork _unitOfWork;
    public SkillService(ICommonIdentityRepository<Skill> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}
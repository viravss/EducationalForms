using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class LeadSkillService : CommonIdentityService<LeadSkill>, ILeadSkillService
{
    private readonly IUnitOfWork _unitOfWork;
    public LeadSkillService(ICommonIdentityRepository<LeadSkill> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}
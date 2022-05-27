using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class LeadSkillRepository : CommonIdentityRepository<LeadSkill>, ILeadSkillRepository
{
    public LeadSkillRepository(EducationalFormsContext context) : base(context)
    {
    }
}
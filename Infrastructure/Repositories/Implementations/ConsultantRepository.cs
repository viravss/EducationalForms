using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class SkillRepository : GenericIdentityRepository<Skill>, ISkillRepository
{
    public SkillRepository(EducationalFormsContext context) : base(context)
    {
    }
}
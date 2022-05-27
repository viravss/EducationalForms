using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class StudentSkillRepository : CommonIdentityRepository<StudentSkill>, IStudentSkillRepository
{
    public StudentSkillRepository(EducationalFormsContext context) : base(context)
    {
    }
}
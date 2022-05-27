using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class StudentServiceRepository : CommonIdentityRepository<StudentService>, IStudentServiceRepository
{
    public StudentServiceRepository(EducationalFormsContext context) : base(context)
    {
    }
}
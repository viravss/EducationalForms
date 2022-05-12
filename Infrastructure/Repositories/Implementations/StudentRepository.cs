using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class StudentRepository : CommonRepository<Student>, IStudentRepository
{
    public StudentRepository(EducationalFormsContext context) : base(context)
    {
    }
}
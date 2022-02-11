using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class ConsultantRepository : GenericRepository<Consultant>, IConsultantRepository
{
    public ConsultantRepository(EducationalFormsContext context) : base(context)
    {
    }
}
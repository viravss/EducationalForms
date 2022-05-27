using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class ConsultantRepository : CommonIdentityRepository<Consultant>, IConsultantRepository
{
    public ConsultantRepository(EducationalFormsContext context) : base(context)
    {
    }
}
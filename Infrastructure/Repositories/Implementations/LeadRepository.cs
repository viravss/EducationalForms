using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class LeadRepository : CommonRepository<Lead>, ILeadRepository
{
    public LeadRepository(EducationalFormsContext context) : base(context)
    {
    }
}